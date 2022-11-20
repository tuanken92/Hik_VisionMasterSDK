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
using VMControls.Interface;

namespace FrontendControl
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// true 代表方案加载成功，false 代表方案关闭
        /// </summary>
        bool mSolutionIsLoad = false;

        /// <summary>
        /// true 已加载运行界面，false 未加载运行界面
        /// </summary>
        bool mFrontedLoad = false;

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        /****************************************************************************
         * @fn           加载运行界面方案数据
         * @fn           Load Frontend Data
         ****************************************************************************/
        private void buttonLoadFrontendData_Click(object sender, EventArgs e)
        {
            string strMsg = null;
            try
            {
                if (mSolutionIsLoad == false)
                {
                    strMsg = "Solution Not loaded yet !";
                    listBoxMsg.Items.Add(strMsg);
                    listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                    return;
                }
                if (vmFrontendControl1 == null) return;
                vmFrontendControl1.LoadFrontendSource();
                mFrontedLoad = true;
            }
            catch (VmException ex)
            {
                strMsg = "Load Frontend Data Fail, Error Code: " + Convert.ToString(ex.errorCode, 16);
                MessageBox.Show(strMsg);
                return;
            }
        }

        /****************************************************************************
         * @fn           执行一次
         * @fn           Execute once
         ****************************************************************************/
        private void buttonExecuteOnce_Click(object sender, EventArgs e)
        {
            string strMsg = null;

            try
            {
                if (mSolutionIsLoad == false)
                {
                    strMsg = "Solution Not loaded yet !";
                    listBoxMsg.Items.Add(strMsg);
                    listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                    return;
                }
                var m_VmSol = VmSolution.Instance[""] as IVMRun;
                if (null == m_VmSol)
                {
                    strMsg = "VmSolution doesn't exist !";
                    listBoxMsg.Items.Add(strMsg);
                    listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                    return;
                }
                m_VmSol.Run();
            }
            catch (VmException ex)
            {
                strMsg = "VmSolution run failed. Error Code: " + Convert.ToString(ex.errorCode, 16);
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                return;
            }

            strMsg = "Process run success";
            listBoxMsg.Items.Add(strMsg);
            listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
        }

        /****************************************************************************
         * @fn           缩小窗口
         * @fn           Change Size
         ****************************************************************************/
        private void buttonChangeSize1_Click(object sender, EventArgs e)
        {
            if (vmFrontendControl1 == null) return;
            if (vmFrontendControl1.Dock != DockStyle.None)
            {
                vmFrontendControl1.Dock = DockStyle.None;
            }
            vmFrontendControl1.Height = vmFrontendControl1.Height - 100;
            vmFrontendControl1.Width = vmFrontendControl1.Width - 100;
            vmFrontendControl1.AutoChangeSize();
        }

        /****************************************************************************
         * @fn           缩小窗口
         * @fn           Change Size
         ****************************************************************************/
        private void buttonChangeSize2_Click(object sender, EventArgs e)
        {
            if (vmFrontendControl1 == null) return;
            if (vmFrontendControl1.Dock != DockStyle.None)
            {
                vmFrontendControl1.Dock = DockStyle.None;
            }
            vmFrontendControl1.Height = vmFrontendControl1.Height + 100;
            vmFrontendControl1.Width = vmFrontendControl1.Width + 100;
            vmFrontendControl1.AutoChangeSize();
        }

        /****************************************************************************
         * @fn           清空消息
         * @fn           Change Size
         ****************************************************************************/
        private void buttonDeleteMsg_Click(object sender, EventArgs e)
        {
            listBoxMsg.Items.Clear();
        }

        /****************************************************************************
         * @fn           随父节点同步变化大小
         * @fn           Clear the contents of the List Box
         ****************************************************************************/
        private void vmFrontendControl1_SizeChanged(object sender, EventArgs e)
        {
            if ((null != vmFrontendControl1) && mFrontedLoad)
            {
                vmFrontendControl1.AutoChangeSize(); 
            }
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
