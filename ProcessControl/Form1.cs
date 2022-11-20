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

namespace ProcessControl
{
    public partial class Form1 : Form
    {
        bool mSolutionIsLoad = false;  //true 代表方案加载成功，false 代表方案关闭
        VmProcedure m_VmPrc = null;
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
                VmSolution.Import(textBoxSolutionPath.Text, textBoxPassword.Text);
                mSolutionIsLoad = true;
            }
            catch(VmException ex)
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

            string strSolutionPath = textBoxSolutionPath.Text;
            string strPassword = textBoxPassword.Text;

            if ((mSolutionIsLoad == true) || (null != m_VmPrc))
            {
                try
                {
                    VmSolution.Export(textBoxSolutionPath.Text, textBoxPassword.Text);
                }
                catch (VmException ex)
                {
                    strMsg = "SaveSolution failed. Error Code: " + Convert.ToString(ex.errorCode, 16);
                    listBoxMsg.Items.Add(strMsg);
                    listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                    return;
                }
                strMsg = "SaveSolution success.";
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
         * @fn           执行一次
         * @fn           Execute once
         ****************************************************************************/
        private void buttonExecuteOnce_Click(object sender, EventArgs e)
        {
            string strMsg = null;
            if ("" == textBoxProcessName.Text)
            {
                strMsg = "Please enter a valid procedure name!";
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                return;
            }

            try
            {                
                m_VmPrc = (VmProcedure)VmSolution.Instance[textBoxProcessName.Text];
                if (null == m_VmPrc)
                {
                    MessageBoxButtons msgType = MessageBoxButtons.OK;
                    DialogResult diagMsg = MessageBox.Show(textBoxProcessName.Text + " name procedure does't exist", "Prompt", msgType);
                    if (diagMsg == DialogResult.OK)
                    {
                        var listModule = VmSolution.Instance.GetAllModuleList();
                        var listProducer = VmSolution.Instance.GetAllProcedureList();
                        return;
                    }
                }
                m_VmPrc.Run();
            }
            catch (VmException ex)
            {
                strMsg = "Process run failed. Error Code: " + Convert.ToString(ex.errorCode, 16);
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                return;
            }

            strMsg = "Process run success";
            listBoxMsg.Items.Add(strMsg);
            listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
        }

        /****************************************************************************
         * @fn           选择流程文件路径
         * @fn           Select the process file path
         ****************************************************************************/
        private void buttonChoosePrcPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "VM Process Files|*.prc*";
            DialogResult openFileRes = openFileDialog.ShowDialog();
            if (DialogResult.OK == openFileRes)
            {
                textBoxProcessPath.Text = openFileDialog.FileName;
            }
        }

        /****************************************************************************
         * @fn           导入流程
         * @fn           Import the process
         ****************************************************************************/
        private void buttonImportProcess_Click(object sender, EventArgs e)
        {
            string strMsg = null;

            try
            {
                m_VmPrc = VmProcedure.ImportProcess(textBoxProcessPath.Text);
            }
            catch (VmException ex)
            {
                strMsg = "ImportProcess failed. Error Code: " + Convert.ToString(ex.errorCode, 16);
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                return;
            }

            strMsg = "ImportProcess success";
            listBoxMsg.Items.Add(strMsg);
            listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
        }

        /****************************************************************************
         * @fn           导出流程
         * @fn           Export the process
         ****************************************************************************/
        private void buttonExportProcess_Click(object sender, EventArgs e)
        {
            string strMsg = null;
            if ("" == textBoxProcessName.Text)
            {
                strMsg = "Please enter a valid procedure name!";
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                return;
            }

            m_VmPrc = (VmProcedure)VmSolution.Instance[textBoxProcessName.Text];
            if(m_VmPrc != null)
            {
                try
                {

                    m_VmPrc.ExportProcess(textBoxProcessPath.Text);
                }
                catch (VmException ex)
                {
                    strMsg = "ExportProcess failed. Error Code: " + Convert.ToString(ex.errorCode, 16);
                    listBoxMsg.Items.Add(strMsg);
                    listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                    return;
                }
                strMsg = "ExportProcess success";
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
            }
            else
            {
                strMsg = "no " + textBoxProcessName.Text + " name procedure";
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
            }
            
        }

        /****************************************************************************
         * @fn           删除一个流程
         * @fn           Delete one process
         ****************************************************************************/
        private void buttonDeleteProcess_Click(object sender, EventArgs e)
        {
            string strMsg = null;
            if ("" == textBoxProcessName.Text)
            {
                strMsg = "Please enter a valid procedure name!";
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                return;
            }

            try
            {

                m_VmPrc = (VmProcedure)VmSolution.Instance[textBoxProcessName.Text];
                if (null == m_VmPrc)
                {
                    strMsg = "No such process.";
                    listBoxMsg.Items.Add(strMsg);
                    listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                    return;
                }
                m_VmPrc.Dispose();
            }
            catch (VmException ex)
            {
                strMsg = "DeleteProcess failed. Error Code: " + Convert.ToString(ex.errorCode, 16);
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                return;
            }

            strMsg = "DeleteProcess success";
            listBoxMsg.Items.Add(strMsg);
            listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
        }

        /****************************************************************************
         * @fn           连续执行
         * @fn           Execute once
         ****************************************************************************/
        private void buttonContinuExecute_Click(object sender, EventArgs e)
        {
            string strMsg = null;
            if ("" == textBoxProcessName.Text)
            {
                strMsg = "Please enter a valid procedure name!";
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                return;
            }

            try
            {
                m_VmPrc = (VmProcedure)VmSolution.Instance[textBoxProcessName.Text];
                if (null == m_VmPrc)
                {
                    MessageBoxButtons msgType = MessageBoxButtons.OK;
                    DialogResult diagMsg = MessageBox.Show(textBoxProcessName.Text + " name procedure does't exist", "Prompt", msgType);
                    if (diagMsg == DialogResult.OK)
                    {
                        return;
                    }
                }

                m_VmPrc.ContinuousRunEnable = true;
            }
            catch (VmException ex)
            {
                strMsg = "ContinuExecute failed. Error Code: " + Convert.ToString(ex.errorCode, 16);
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                return;
            }

            strMsg = "ContinuExecute success";
            listBoxMsg.Items.Add(strMsg);
            listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
        }

        /****************************************************************************
         * @fn           停止执行
         * @fn           Execute once
         ****************************************************************************/
        private void buttonStopExecute_Click(object sender, EventArgs e)
        {
            string strMsg = null;
            if ("" == textBoxProcessName.Text)
            {
                strMsg = "Please enter a valid procedure name!";
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                return;
            }

            try
            {
                m_VmPrc = (VmProcedure)VmSolution.Instance[textBoxProcessName.Text];
                if (null == m_VmPrc)
                {
                    MessageBoxButtons msgType = MessageBoxButtons.OK;
                    DialogResult diagMsg = MessageBox.Show(textBoxProcessName.Text + " name procedure does't exist", "Prompt", msgType);
                    if (diagMsg == DialogResult.OK)
                    {
                        return;
                    }
                }
                m_VmPrc.ContinuousRunEnable = false;
            }
            catch (VmException ex)
            {
                strMsg = "StopExecute failed. Error Code: " + Convert.ToString(ex.errorCode, 16);
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                return;
            }

            strMsg = "StopExecute success";
            listBoxMsg.Items.Add(strMsg);
            listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
        }

        /****************************************************************************
         * @fn           设置连续执行时间间隔
         * @fn           Set continuous execution time interval
         ****************************************************************************/
        private void buttonSetTimeInterval_Click(object sender, EventArgs e)
        {
            string strMsg = null;
            if ("" == textBoxProcessName.Text)
            {
                strMsg = "Please enter a valid procedure name!";
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                return;
            }

            try
            {
                string strTimeInteval = textBoxTimeInterval.Text;
                if (string.IsNullOrEmpty(strTimeInteval))
                {
                    MessageBoxButtons msgType = MessageBoxButtons.OK;
                    DialogResult diagMsg = MessageBox.Show("Please enter the time interval!", "Prompt", msgType);
                    if (diagMsg == DialogResult.OK)
                    {
                        return;
                    }
                }

                uint nTimeInterval = 0;
                nTimeInterval = uint.Parse(strTimeInteval);

                m_VmPrc = (VmProcedure)VmSolution.Instance[textBoxProcessName.Text];
                if (null == m_VmPrc)
                {
                    MessageBoxButtons msgType = MessageBoxButtons.OK;
                    DialogResult diagMsg = MessageBox.Show(textBoxProcessName.Text + " name procedure does't exist", "Prompt", msgType);
                    if (diagMsg == DialogResult.OK)
                    {
                        return;
                    }
                }
                m_VmPrc.SetContinousRunInterval(nTimeInterval);
            }
            catch (VmException ex)
            {
                strMsg = "SetContinousRunInterval failed. Error Code: " + Convert.ToString(ex.errorCode, 16);
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                return;
            }

            strMsg = "SetContinousRunInterval success";
            listBoxMsg.Items.Add(strMsg);
            listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
            
        }

        /******************************************************************************
         *  @fn       设置流程禁用状态
         *  @fn       Set the disable/enable status of specified process
         ******************************************************************************/
        private void buttonShieldProcess_Click(object sender, EventArgs e)
        {
            string strMsg = null;
            if ("" == textBoxProcessName.Text)
            {
                strMsg = "Please enter a valid procedure name!";
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                return;
            }
            m_VmPrc = (VmProcedure)VmSolution.Instance[textBoxProcessName.Text];
            if (null == m_VmPrc)
            {
                MessageBoxButtons msgType = MessageBoxButtons.OK;
                DialogResult diagMsg = MessageBox.Show(textBoxProcessName.Text + " name procedure does't exist", "Prompt", msgType);
                if (diagMsg == DialogResult.OK)
                {
                    return;
                }
            }
            m_VmPrc.IsEnabled = false;

            strMsg = "ShieldProcess success";
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
    }
}
