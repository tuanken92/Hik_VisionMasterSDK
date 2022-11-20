using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolutionControl
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            catch(Exception ex)
            {
                VM.PlatformSDKCS.VmException vmEx = GetVmException(ex);
                if (null != vmEx)
                {
                    string strMsg = "InitControl failed. Error Code: " + Convert.ToString(vmEx.errorCode, 16);
                    MessageBox.Show(strMsg);
                }
                else
                {
                    return;
                }
            }
        }

        /****************************************************************************
         * @fn           获取内部异常信息
         * @fn           Gets Vm exception information
         ****************************************************************************/
        private static VM.PlatformSDKCS.VmException GetVmException(Exception ex)
        {
            VM.PlatformSDKCS.VmException vmException = null;
            while (ex != null)
            {
                if (ex is VM.PlatformSDKCS.VmException)
                {
                    vmException = (VM.PlatformSDKCS.VmException)ex;
                    break;
                }
                else
                {
                    ex = ex.InnerException;
                }
            }
            return vmException;
        }
    }
}
