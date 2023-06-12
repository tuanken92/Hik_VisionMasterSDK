using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VM.Core;
using VM.PlatformSDKCS;

namespace SolutionControl
{
    public partial class Form1 : Form
    {
        bool mSolutionIsLoad = false;  //true 代表方案加载成功，false 代表方案关闭
        List<VmProcedure> processList;

        public Form1()
        {
            InitializeComponent();
        }

        /****************************************************************************
         * @fn           初始化
         * @fn           Initialization
         ****************************************************************************/
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ListBox.CheckForIllegalCrossThreadCalls = false;
            }
            catch(Exception ex)
            {
                 return;
            }
        }

        /****************************************************************************
         * @fn           选择方案路径
         * @fn           Select solution's path
         ****************************************************************************/
        private void buttonChooseSoluPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "VM Sol File|*.sol*";
            DialogResult openFileRes = openFileDialog.ShowDialog();
            if (DialogResult.OK == openFileRes)
            {
                textBoxSolutionPath.Text = openFileDialog.FileName;
            }
        }

        /****************************************************************************
         * @fn           加载方案
         * @fn           Load solution
         ****************************************************************************/
        private void buttonLoadSolution_Click(object sender, EventArgs e)
        {
            string strMsg = null;
            int nProgress = 0;
            progressBarSaveAndLoad.Value = nProgress;
            labelProgress.Text = nProgress.ToString();
            labelProgress.Refresh();

            try
            {
                VmSolution.Load(textBoxSolutionPath.Text, textBoxPassword.Text);
                processList = GetCurrentSolProcedureList();
                RegisterProcedureWorkEndCallback(processList);
                mSolutionIsLoad = true;
            }
            catch (VmException ex)
            {
                strMsg = "LoadSolution failed. Error Code: " + Convert.ToString(ex.errorCode, 16);
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                return;
            }

            strMsg = "LoadSolution success";
            listBoxMsg.Items.Add(strMsg);
            listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;

            nProgress = 100;
            labelProgress.Text = nProgress.ToString();
            labelProgress.Refresh();
            progressBarSaveAndLoad.Value = Convert.ToInt32(nProgress);
        }


        private List<VmProcedure> GetCurrentSolProcedureList()
        {
            List<VmProcedure> procedureList = new List<VmProcedure>();
            var processInfoList = VmSolution.Instance.GetAllProcedureList();
            for (int i = 0; i < processInfoList.nNum; i++)
            {
                string processName = processInfoList.astProcessInfo[i].strProcessName;
                procedureList.Add((VmProcedure)VmSolution.Instance[processName]);
                Console.WriteLine(processName);
            }
            return procedureList;
        }


        public void RegisterProcedureWorkEndCallback(List<VmProcedure> lst)
        {
            try
            {
                foreach (var vmProcedure in processList)
                {
                    vmProcedure.OnWorkEndStatusCallBack += VmProcedure_OnWorkEndStatusCallBack;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VmProcedure_OnWorkEndStatusCallBack(object sender, EventArgs e)
        {
            try
            {
                VmProcedure procedure = sender as VmProcedure;
                if (procedure != null)
                {
                    var outputList = procedure.ModuResult.GetAllOutputNameInfo();
                    bool outputConfigIsWrong = true;
                    //获取流程输出配置中为out的输出项
                    foreach (var ioNameInfo in outputList)
                    {
                        Console.WriteLine(ioNameInfo.Name);
                        Console.WriteLine(ioNameInfo.TypeName);
                        var result = procedure.ModuResult.GetOutputPointArray(ioNameInfo.Name);
                        if (result != null)
                        {
                            foreach(var io in result)
                            {
                                Console.WriteLine($"data = {io.X}, {io.Y}");
                            }    
                        }    
                        //if (ioNameInfo.Name == "out" &&
                        //    ioNameInfo.TypeName == IMVS_MODULE_BASE_DATA_TYPE.IMVS_GRAP_TYPE_STRING)
                        //{
                        //    var result = procedure.ModuResult.GetOutputString(ioNameInfo.Name);
                        //    string resultStrValue = result.astStringVal[0].strValue;
                        //    AppendLog("流程结果:" + resultStrValue);
                        //    UpdateResultListBox("流程结果:" + resultStrValue);
                        //    UpdateLableState(resultStrValue);
                        //    outputConfigIsWrong = false;
                        //}
                    }
                    //流程输出配置有误，提示输出配置错误
                    if (outputConfigIsWrong)
                    {
                        Console.WriteLine("outputConfigIsWrong");
                    }
                    Console.WriteLine("Time process: " + procedure.ProcessTime);


                    var outputImage = procedure.ModuResult.GetOutputImageV2("ImageData");
                    if (outputImage != null)
                    {
                        try
                        {
                            var w = outputImage.Width;
                            var h = outputImage.Height;
                            var l = outputImage.DataLen;
                            var type = outputImage.Pixelformat;
                            var stride = type == VMPixelFormat.VM_PIXEL_MONO_08 ? w : w * 3;
                            var format = type == VMPixelFormat.VM_PIXEL_MONO_08 ?
                                                                    System.Drawing.Imaging.PixelFormat.Format8bppIndexed
                                                                    : System.Drawing.Imaging.PixelFormat.Format24bppRgb;

                            Bitmap bitmap = new Bitmap(w, h, stride, format, outputImage.ImageData);
                            bitmap.Save(@"D:\Hik\abc.bmp");

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /****************************************************************************
         * @fn           保存方案
         * @fn           Save solution
         ****************************************************************************/
        private void buttonSaveSolution_Click(object sender, EventArgs e)
        {
            string strMsg = null;
            int nProgress = 0;
            progressBarSaveAndLoad.Value = nProgress;
            labelProgress.Text = nProgress.ToString();
            labelProgress.Refresh();

            if (mSolutionIsLoad == true)
            {                
                try
                {
                    VmSolution.SaveAs(textBoxSolutionPath.Text, textBoxPassword.Text);
                }
                catch (VmException ex)
                {
                    strMsg = "SaveSolution failed. Error Code: " + Convert.ToString(ex.errorCode, 16);
                    listBoxMsg.Items.Add(strMsg);
                    listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                    return;
                }

                strMsg = "SaveSolution success";
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;

                nProgress = 100;
                labelProgress.Text = nProgress.ToString();
                labelProgress.Refresh();
                progressBarSaveAndLoad.Value = Convert.ToInt32(nProgress);
            }
            else
            {
                strMsg = "no solution file.";
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
            }
        }

        /****************************************************************************
         * @fn           检查方案密码
         * @fn           Check solution's password
         ****************************************************************************/
        private void buttonCheckPassWord_Click(object sender, EventArgs e)
        {
            string strMsg = null;
            try
            {
                if (mSolutionIsLoad == true)
                {
                    if (VmSolution.Instance.HasPassword(textBoxSolutionPath.Text))
                    {
                        strMsg = "The solution has password.";
                    }
                    else
                    {
                        strMsg = "The solution has no password.";
                    }
                    listBoxMsg.Items.Add(strMsg);
                    listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                }
                else
                {
                    strMsg = "No solution file.";
                    listBoxMsg.Items.Add(strMsg);
                    listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                }
            }
            catch (VmException ex)
            {
                strMsg = "CheckPassWord failed, Error Code: " + Convert.ToString(ex.errorCode, 16);
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;

                return;
            }
        }

        /****************************************************************************
         * @fn           获取方案版本
         * @fn           Get solution version
         ****************************************************************************/
        private void buttonGetSolutionVersion_Click(object sender, EventArgs e)
        {            
            if(mSolutionIsLoad == true)
            {
                string strMsg = null;
                try
                {
                    string strSolutionVersion = "The solution version is " +
                                            VmSolution.Instance.GetSolutionVersion(textBoxSolutionPath.Text, textBoxPassword.Text);
                    listBoxMsg.Items.Add(strSolutionVersion);
                    listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                }
                catch (VmException ex)
                {
                    strMsg = "GetSolutionVersion failed, Error Code: " + Convert.ToString(ex.errorCode, 16);
                    listBoxMsg.Items.Add(strMsg);
                    listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;

                    return;
                }
            }
            else
            {
                string strMsg = "no solution file.";
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
            }
            
        }

        /****************************************************************************
         * @fn           获取方案路径
         * @fn           Get solution path
         ****************************************************************************/
        private void buttonGetSolutionPath_Click(object sender, EventArgs e)
        {
            if(mSolutionIsLoad == true)
            {
                string strSolutionPath = "The solution path is " + VmSolution.Instance.SolutionPath;
                listBoxMsg.Items.Add(strSolutionPath);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
            }
            else
            {
                string strMsg = "no solution file.";
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
            }
            
        }

        /****************************************************************************
         * @fn           关闭方案
         * @fn           Close solution
         ****************************************************************************/
        private void buttonCloseSolution_Click(object sender, EventArgs e)
        {
            string strMsg = null;
            try
            {
                if(mSolutionIsLoad == true)
                {
                    VmSolution.Instance.CloseSolution();
                    mSolutionIsLoad = false;  // 代表方案已经关闭
                }
                else
                {
                    strMsg = "No solution file.";
                    listBoxMsg.Items.Add(strMsg);
                    listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                    return;
                }
                
            }
            catch (VmException ex)
            {
                strMsg = "CloseSolution failed. Error Code: " + Convert.ToString(ex.errorCode, 16);
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                return;
            }
			
			strMsg = "CloseSolution success";
            listBoxMsg.Items.Add(strMsg);
            listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
        }

        /****************************************************************************
         * @fn           清空消息
         * @fn           Clear the contents of the List Box
         ****************************************************************************/
        private void buttonDeleteMsg_Click(object sender, EventArgs e)
        {
            listBoxMsg.Items.Clear();
        }

        /****************************************************************************
         * @fn           退出
         * @fn           Quit
         ****************************************************************************/
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            VmSolution.Instance?.Dispose();
        }

        private void btnRunOnce_Click(object sender, EventArgs e)
        {
            try
            {
                    VmProcedure procedure = VmSolution.Instance[processName] as VmProcedure;
                    if (procedure != null)
                    {
                        procedure.Run();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string processName = "Blob-Tape";
        private void btnRunContinuous_Click(object sender, EventArgs e)
        {
            try
            {
                    VmProcedure procedure = VmSolution.Instance[processName] as VmProcedure;
                    if (procedure != null)
                    {
                        procedure.ContinuousRunEnable = procedure.ContinuousRunEnable ^ true;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
