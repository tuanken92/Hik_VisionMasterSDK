namespace SolutionControl
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxSolution = new System.Windows.Forms.GroupBox();
            this.buttonGetSolutionPath = new System.Windows.Forms.Button();
            this.buttonGetSolutionVersion = new System.Windows.Forms.Button();
            this.labelProgress = new System.Windows.Forms.Label();
            this.progressBarSaveAndLoad = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonCheckPassWord = new System.Windows.Forms.Button();
            this.textBoxSolutionPath = new System.Windows.Forms.TextBox();
            this.buttonChooseSoluPath = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonCloseSolution = new System.Windows.Forms.Button();
            this.buttonLoadSolution = new System.Windows.Forms.Button();
            this.buttonSaveSolution = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxMsg = new System.Windows.Forms.GroupBox();
            this.buttonDeleteMsg = new System.Windows.Forms.Button();
            this.listBoxMsg = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vmProcedureConfigControl1 = new VMControls.Winform.Release.VmProcedureConfigControl();
            this.btnRunOnce = new System.Windows.Forms.Button();
            this.btnRunContinuous = new System.Windows.Forms.Button();
            this.groupBoxSolution.SuspendLayout();
            this.groupBoxMsg.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSolution
            // 
            this.groupBoxSolution.Controls.Add(this.buttonGetSolutionPath);
            this.groupBoxSolution.Controls.Add(this.buttonGetSolutionVersion);
            this.groupBoxSolution.Controls.Add(this.labelProgress);
            this.groupBoxSolution.Controls.Add(this.progressBarSaveAndLoad);
            this.groupBoxSolution.Controls.Add(this.label9);
            this.groupBoxSolution.Controls.Add(this.buttonCheckPassWord);
            this.groupBoxSolution.Controls.Add(this.textBoxSolutionPath);
            this.groupBoxSolution.Controls.Add(this.buttonChooseSoluPath);
            this.groupBoxSolution.Controls.Add(this.label8);
            this.groupBoxSolution.Controls.Add(this.textBoxPassword);
            this.groupBoxSolution.Controls.Add(this.buttonCloseSolution);
            this.groupBoxSolution.Controls.Add(this.btnRunContinuous);
            this.groupBoxSolution.Controls.Add(this.btnRunOnce);
            this.groupBoxSolution.Controls.Add(this.buttonLoadSolution);
            this.groupBoxSolution.Controls.Add(this.buttonSaveSolution);
            this.groupBoxSolution.Controls.Add(this.label11);
            this.groupBoxSolution.Font = new System.Drawing.Font("Cambria", 9F);
            this.groupBoxSolution.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSolution.Name = "groupBoxSolution";
            this.groupBoxSolution.Size = new System.Drawing.Size(468, 313);
            this.groupBoxSolution.TabIndex = 52;
            this.groupBoxSolution.TabStop = false;
            this.groupBoxSolution.Text = "Main";
            // 
            // buttonGetSolutionPath
            // 
            this.buttonGetSolutionPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGetSolutionPath.Location = new System.Drawing.Point(10, 249);
            this.buttonGetSolutionPath.Name = "buttonGetSolutionPath";
            this.buttonGetSolutionPath.Size = new System.Drawing.Size(111, 30);
            this.buttonGetSolutionPath.TabIndex = 53;
            this.buttonGetSolutionPath.Text = "Get Solution Path";
            this.buttonGetSolutionPath.UseVisualStyleBackColor = true;
            this.buttonGetSolutionPath.Click += new System.EventHandler(this.buttonGetSolutionPath_Click);
            // 
            // buttonGetSolutionVersion
            // 
            this.buttonGetSolutionVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGetSolutionVersion.Location = new System.Drawing.Point(10, 193);
            this.buttonGetSolutionVersion.Name = "buttonGetSolutionVersion";
            this.buttonGetSolutionVersion.Size = new System.Drawing.Size(111, 30);
            this.buttonGetSolutionVersion.TabIndex = 50;
            this.buttonGetSolutionVersion.Text = "Get Solution Ver";
            this.buttonGetSolutionVersion.UseVisualStyleBackColor = true;
            this.buttonGetSolutionVersion.Click += new System.EventHandler(this.buttonGetSolutionVersion_Click);
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelProgress.Location = new System.Drawing.Point(67, 95);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(14, 14);
            this.labelProgress.TabIndex = 29;
            this.labelProgress.Text = "0";
            // 
            // progressBarSaveAndLoad
            // 
            this.progressBarSaveAndLoad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBarSaveAndLoad.Location = new System.Drawing.Point(94, 92);
            this.progressBarSaveAndLoad.Name = "progressBarSaveAndLoad";
            this.progressBarSaveAndLoad.Size = new System.Drawing.Size(224, 18);
            this.progressBarSaveAndLoad.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(9, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 14);
            this.label9.TabIndex = 9;
            this.label9.Text = "Solution Path";
            // 
            // buttonCheckPassWord
            // 
            this.buttonCheckPassWord.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCheckPassWord.Location = new System.Drawing.Point(348, 249);
            this.buttonCheckPassWord.Name = "buttonCheckPassWord";
            this.buttonCheckPassWord.Size = new System.Drawing.Size(100, 30);
            this.buttonCheckPassWord.TabIndex = 4;
            this.buttonCheckPassWord.Text = "Check Password";
            this.buttonCheckPassWord.UseVisualStyleBackColor = true;
            this.buttonCheckPassWord.Click += new System.EventHandler(this.buttonCheckPassWord_Click);
            // 
            // textBoxSolutionPath
            // 
            this.textBoxSolutionPath.Location = new System.Drawing.Point(94, 24);
            this.textBoxSolutionPath.Name = "textBoxSolutionPath";
            this.textBoxSolutionPath.Size = new System.Drawing.Size(224, 22);
            this.textBoxSolutionPath.TabIndex = 10;
            // 
            // buttonChooseSoluPath
            // 
            this.buttonChooseSoluPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonChooseSoluPath.Location = new System.Drawing.Point(337, 19);
            this.buttonChooseSoluPath.Name = "buttonChooseSoluPath";
            this.buttonChooseSoluPath.Size = new System.Drawing.Size(111, 30);
            this.buttonChooseSoluPath.TabIndex = 11;
            this.buttonChooseSoluPath.Text = "Select";
            this.buttonChooseSoluPath.UseVisualStyleBackColor = true;
            this.buttonChooseSoluPath.Click += new System.EventHandler(this.buttonChooseSoluPath_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(11, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 14);
            this.label8.TabIndex = 12;
            this.label8.Text = "Flow pass:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(94, 57);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(224, 22);
            this.textBoxPassword.TabIndex = 13;
            // 
            // buttonCloseSolution
            // 
            this.buttonCloseSolution.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCloseSolution.Location = new System.Drawing.Point(348, 193);
            this.buttonCloseSolution.Name = "buttonCloseSolution";
            this.buttonCloseSolution.Size = new System.Drawing.Size(100, 30);
            this.buttonCloseSolution.TabIndex = 16;
            this.buttonCloseSolution.Text = "Close Solution";
            this.buttonCloseSolution.UseVisualStyleBackColor = true;
            this.buttonCloseSolution.Click += new System.EventHandler(this.buttonCloseSolution_Click);
            // 
            // buttonLoadSolution
            // 
            this.buttonLoadSolution.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonLoadSolution.Location = new System.Drawing.Point(10, 137);
            this.buttonLoadSolution.Name = "buttonLoadSolution";
            this.buttonLoadSolution.Size = new System.Drawing.Size(111, 30);
            this.buttonLoadSolution.TabIndex = 15;
            this.buttonLoadSolution.Text = "Load Solution";
            this.buttonLoadSolution.UseVisualStyleBackColor = true;
            this.buttonLoadSolution.Click += new System.EventHandler(this.buttonLoadSolution_Click);
            // 
            // buttonSaveSolution
            // 
            this.buttonSaveSolution.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSaveSolution.Location = new System.Drawing.Point(348, 137);
            this.buttonSaveSolution.Name = "buttonSaveSolution";
            this.buttonSaveSolution.Size = new System.Drawing.Size(100, 30);
            this.buttonSaveSolution.TabIndex = 14;
            this.buttonSaveSolution.Text = "Save Solution";
            this.buttonSaveSolution.UseVisualStyleBackColor = true;
            this.buttonSaveSolution.Click += new System.EventHandler(this.buttonSaveSolution_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(11, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 14);
            this.label11.TabIndex = 9;
            this.label11.Text = "Progress：";
            // 
            // groupBoxMsg
            // 
            this.groupBoxMsg.Controls.Add(this.buttonDeleteMsg);
            this.groupBoxMsg.Controls.Add(this.listBoxMsg);
            this.groupBoxMsg.Font = new System.Drawing.Font("Cambria", 9F);
            this.groupBoxMsg.Location = new System.Drawing.Point(12, 348);
            this.groupBoxMsg.Name = "groupBoxMsg";
            this.groupBoxMsg.Size = new System.Drawing.Size(468, 175);
            this.groupBoxMsg.TabIndex = 53;
            this.groupBoxMsg.TabStop = false;
            this.groupBoxMsg.Text = "Message";
            // 
            // buttonDeleteMsg
            // 
            this.buttonDeleteMsg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDeleteMsg.Location = new System.Drawing.Point(350, 21);
            this.buttonDeleteMsg.Name = "buttonDeleteMsg";
            this.buttonDeleteMsg.Size = new System.Drawing.Size(98, 30);
            this.buttonDeleteMsg.TabIndex = 1;
            this.buttonDeleteMsg.Text = "Clear";
            this.buttonDeleteMsg.UseVisualStyleBackColor = true;
            this.buttonDeleteMsg.Click += new System.EventHandler(this.buttonDeleteMsg_Click);
            // 
            // listBoxMsg
            // 
            this.listBoxMsg.FormattingEnabled = true;
            this.listBoxMsg.ItemHeight = 14;
            this.listBoxMsg.Location = new System.Drawing.Point(10, 59);
            this.listBoxMsg.Name = "listBoxMsg";
            this.listBoxMsg.Size = new System.Drawing.Size(438, 88);
            this.listBoxMsg.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vmProcedureConfigControl1);
            this.groupBox1.Location = new System.Drawing.Point(496, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 511);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            // 
            // vmProcedureConfigControl1
            // 
            this.vmProcedureConfigControl1.Location = new System.Drawing.Point(15, 20);
            this.vmProcedureConfigControl1.Margin = new System.Windows.Forms.Padding(2);
            this.vmProcedureConfigControl1.Name = "vmProcedureConfigControl1";
            this.vmProcedureConfigControl1.Size = new System.Drawing.Size(534, 478);
            this.vmProcedureConfigControl1.TabIndex = 0;
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            // 
            // btnRunOnce
            // 
            this.btnRunOnce.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRunOnce.Location = new System.Drawing.Point(177, 137);
            this.btnRunOnce.Name = "btnRunOnce";
            this.btnRunOnce.Size = new System.Drawing.Size(111, 30);
            this.btnRunOnce.TabIndex = 15;
            this.btnRunOnce.Text = "Run";
            this.btnRunOnce.UseVisualStyleBackColor = true;
            this.btnRunOnce.Click += new System.EventHandler(this.btnRunOnce_Click);
            // 
            // btnRunContinuous
            // 
            this.btnRunContinuous.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRunContinuous.Location = new System.Drawing.Point(177, 193);
            this.btnRunContinuous.Name = "btnRunContinuous";
            this.btnRunContinuous.Size = new System.Drawing.Size(111, 30);
            this.btnRunContinuous.TabIndex = 15;
            this.btnRunContinuous.Text = "Run Continuous";
            this.btnRunContinuous.UseVisualStyleBackColor = true;
            this.btnRunContinuous.Click += new System.EventHandler(this.btnRunContinuous_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1074, 533);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxMsg);
            this.Controls.Add(this.groupBoxSolution);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SolutionControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSolution.ResumeLayout(false);
            this.groupBoxSolution.PerformLayout();
            this.groupBoxMsg.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSolution;
        private System.Windows.Forms.Button buttonGetSolutionPath;
        private System.Windows.Forms.Button buttonGetSolutionVersion;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.ProgressBar progressBarSaveAndLoad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCheckPassWord;
        private System.Windows.Forms.TextBox textBoxSolutionPath;
        private System.Windows.Forms.Button buttonChooseSoluPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonCloseSolution;
        private System.Windows.Forms.Button buttonLoadSolution;
        private System.Windows.Forms.Button buttonSaveSolution;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBoxMsg;
        private System.Windows.Forms.Button buttonDeleteMsg;
        private System.Windows.Forms.ListBox listBoxMsg;
        private System.Windows.Forms.GroupBox groupBox1;
        private VMControls.Winform.Release.VmProcedureConfigControl vmProcedureConfigControl1;
        private System.Windows.Forms.Button btnRunOnce;
        private System.Windows.Forms.Button btnRunContinuous;
    }
}

