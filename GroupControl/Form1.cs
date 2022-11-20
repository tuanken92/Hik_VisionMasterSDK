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
using IMVSGroupCs;
using IMVSCircleFindModuCs;

namespace GroupControl
{
    public partial class Form1 : Form
    {
        IMVSGroupTool mGroupTool = null;

        public Form1()
        {
            InitializeComponent();
        }

        /****************************************************************************
         * @fn           选择方案路径
         * @fn           Select solution's path
         ****************************************************************************/
        private void buttonChooseGroPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "VM Gro File|*.gro*";
            DialogResult openFileRes = openFileDialog.ShowDialog();
            if (DialogResult.OK == openFileRes)
            {
                textBoxGroPath.Text = openFileDialog.FileName;
            }
        }

        /****************************************************************************
         * @fn           导入Group
         * @fn           Import group
         ****************************************************************************/
        private void buttonImportGroup_Click(object sender, EventArgs e)
        {
            string strMsg = null;
            try
            {
                mGroupTool = IMVSGroupTool.LoadGroup(textBoxGroPath.Text);
            }
            catch (VmException ex)
            {
                strMsg = "LoadGroupFromFile failed. Error Code: " + Convert.ToString(ex.errorCode, 16);
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                return;
            }

            strMsg = "LoadGroupFromFile success";
            listBoxMsg.Items.Add(strMsg);
            listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
        }

        /****************************************************************************
         * @fn           导出Group
         * @fn           Export group
         ****************************************************************************/
        private void buttonExportGroup_Click(object sender, EventArgs e)
        {
            string strMsg = null;
            if ("" == textBoxGroPath.Text)
            {
                strMsg = "Please enter a valid group path!";
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                return;
            }

            if (null != mGroupTool)
            {
                try
                {
                    mGroupTool.ExportGroup(textBoxGroPath.Text);
                }
                catch (VmException ex)
                {
                    strMsg = "SaveGroupToFile failed. Error Code: " + Convert.ToString(ex.errorCode, 16);
                    listBoxMsg.Items.Add(strMsg);
                    listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                    return;
                }

                strMsg = "SaveGroupToFile success";
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
            }
            else
            {
                strMsg = "There is no group!";
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

            if (null != mGroupTool)
            {
                try
                {
                    IMVSCircleFindModuTool circleFindModule = (IMVSCircleFindModuTool)mGroupTool["圆查找1"];
                    vmRenderControl1.ModuleSource = circleFindModule;

                    mGroupTool.Run();
                }
                catch (VmException ex)
                {
                    strMsg = "Run failed. Error Code: " + Convert.ToString(ex.errorCode, 16);
                    listBoxMsg.Items.Add(strMsg);
                    listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                    return;
                }

                strMsg = "Run success";
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
            }
            else
            {
                strMsg = "There is no group!";
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
            }
        }

        /****************************************************************************
         * @fn           绑定参数配置控件
         * @fn           Binding param
         ****************************************************************************/
        private void buttonBindParamControl_Click(object sender, EventArgs e)
        {
            string strMsg = "";
            if (null == mGroupTool)
            {
                strMsg = "Import Group first.";
                listBoxMsg.Items.Add(strMsg);
                listBoxMsg.TopIndex = listBoxMsg.Items.Count - 1;
                return;
            }

            vmParamsConfigWithRenderControl1.ModuleSource = mGroupTool;

            strMsg = "Binding param control success";
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
            mGroupTool?.DestroyGroup();
        }
    }
}
