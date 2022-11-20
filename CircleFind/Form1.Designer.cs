namespace CircleFind
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
            this.labelProgress = new System.Windows.Forms.Label();
            this.progressBarSaveAndLoad = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSolutionPath = new System.Windows.Forms.TextBox();
            this.buttonChooseSoluPath = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLoadSolution = new System.Windows.Forms.Button();
            this.buttonSaveSolution = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vmParamsConfigWithRenderControl1 = new VMControls.Winform.Release.VmParamsConfigWithRenderControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vmRenderControl1 = new VMControls.Winform.Release.VmRenderControl();
            this.buttonExecuteOnce = new System.Windows.Forms.Button();
            this.groupBoxMsg = new System.Windows.Forms.GroupBox();
            this.buttonDeleteMsg = new System.Windows.Forms.Button();
            this.listBoxMsg = new System.Windows.Forms.ListBox();
            this.buttonGetResult = new System.Windows.Forms.Button();
            this.buttonParam = new System.Windows.Forms.Button();
            this.groupBoxSolution.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSolution
            // 
            this.groupBoxSolution.Controls.Add(this.labelProgress);
            this.groupBoxSolution.Controls.Add(this.progressBarSaveAndLoad);
            this.groupBoxSolution.Controls.Add(this.label9);
            this.groupBoxSolution.Controls.Add(this.textBoxSolutionPath);
            this.groupBoxSolution.Controls.Add(this.buttonChooseSoluPath);
            this.groupBoxSolution.Controls.Add(this.label8);
            this.groupBoxSolution.Controls.Add(this.textBoxPassword);
            this.groupBoxSolution.Controls.Add(this.buttonLoadSolution);
            this.groupBoxSolution.Controls.Add(this.buttonSaveSolution);
            this.groupBoxSolution.Controls.Add(this.label11);
            this.groupBoxSolution.Font = new System.Drawing.Font("Cambria", 9F);
            this.groupBoxSolution.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSolution.Name = "groupBoxSolution";
            this.groupBoxSolution.Size = new System.Drawing.Size(558, 101);
            this.groupBoxSolution.TabIndex = 53;
            this.groupBoxSolution.TabStop = false;
            this.groupBoxSolution.Text = "Main";
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelProgress.Location = new System.Drawing.Point(67, 70);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(14, 14);
            this.labelProgress.TabIndex = 29;
            this.labelProgress.Text = "0";
            // 
            // progressBarSaveAndLoad
            // 
            this.progressBarSaveAndLoad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBarSaveAndLoad.Location = new System.Drawing.Point(94, 67);
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
            this.label9.Size = new System.Drawing.Size(37, 14);
            this.label9.TabIndex = 9;
            this.label9.Text = "Path：";
            // 
            // textBoxSolutionPath
            // 
            this.textBoxSolutionPath.Location = new System.Drawing.Point(94, 24);
            this.textBoxSolutionPath.Name = "textBoxSolutionPath";
            this.textBoxSolutionPath.Size = new System.Drawing.Size(166, 22);
            this.textBoxSolutionPath.TabIndex = 10;
            // 
            // buttonChooseSoluPath
            // 
            this.buttonChooseSoluPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonChooseSoluPath.Location = new System.Drawing.Point(269, 18);
            this.buttonChooseSoluPath.Name = "buttonChooseSoluPath";
            this.buttonChooseSoluPath.Size = new System.Drawing.Size(111, 30);
            this.buttonChooseSoluPath.TabIndex = 11;
            this.buttonChooseSoluPath.Text = "Select Solu Path";
            this.buttonChooseSoluPath.UseVisualStyleBackColor = true;
            this.buttonChooseSoluPath.Click += new System.EventHandler(this.buttonChooseSoluPath_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(383, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 14);
            this.label8.TabIndex = 12;
            this.label8.Text = "Password：";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(454, 21);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(91, 22);
            this.textBoxPassword.TabIndex = 13;
            // 
            // buttonLoadSolution
            // 
            this.buttonLoadSolution.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonLoadSolution.Location = new System.Drawing.Point(333, 60);
            this.buttonLoadSolution.Name = "buttonLoadSolution";
            this.buttonLoadSolution.Size = new System.Drawing.Size(100, 30);
            this.buttonLoadSolution.TabIndex = 15;
            this.buttonLoadSolution.Text = "Load";
            this.buttonLoadSolution.UseVisualStyleBackColor = true;
            this.buttonLoadSolution.Click += new System.EventHandler(this.buttonLoadSolution_Click);
            // 
            // buttonSaveSolution
            // 
            this.buttonSaveSolution.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSaveSolution.Location = new System.Drawing.Point(448, 60);
            this.buttonSaveSolution.Name = "buttonSaveSolution";
            this.buttonSaveSolution.Size = new System.Drawing.Size(100, 30);
            this.buttonSaveSolution.TabIndex = 14;
            this.buttonSaveSolution.Text = "Save";
            this.buttonSaveSolution.UseVisualStyleBackColor = true;
            this.buttonSaveSolution.Click += new System.EventHandler(this.buttonSaveSolution_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(11, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 14);
            this.label11.TabIndex = 9;
            this.label11.Text = "Progress：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vmParamsConfigWithRenderControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 450);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数配置区";
            // 
            // vmParamsConfigWithRenderControl1
            // 
            this.vmParamsConfigWithRenderControl1.BackColor = System.Drawing.Color.White;
            this.vmParamsConfigWithRenderControl1.CoordinateInfoVisible = true;
            this.vmParamsConfigWithRenderControl1.ImageSource = null;
            this.vmParamsConfigWithRenderControl1.Location = new System.Drawing.Point(11, 20);
            this.vmParamsConfigWithRenderControl1.ModuleSource = null;
            this.vmParamsConfigWithRenderControl1.Name = "vmParamsConfigWithRenderControl1";
            this.vmParamsConfigWithRenderControl1.ParamsConfig = null;
            this.vmParamsConfigWithRenderControl1.ROIVisible = true;
            this.vmParamsConfigWithRenderControl1.Size = new System.Drawing.Size(537, 411);
            this.vmParamsConfigWithRenderControl1.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vmRenderControl1);
            this.groupBox2.Location = new System.Drawing.Point(585, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 450);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "结果渲染区";
            // 
            // vmRenderControl1
            // 
            this.vmRenderControl1.BackColor = System.Drawing.Color.Black;
            this.vmRenderControl1.CoordinateInfoVisible = true;
            this.vmRenderControl1.ImageSource = null;
            this.vmRenderControl1.Location = new System.Drawing.Point(6, 20);
            this.vmRenderControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vmRenderControl1.ModuleSource = null;
            this.vmRenderControl1.Name = "vmRenderControl1";
            this.vmRenderControl1.Size = new System.Drawing.Size(487, 411);
            this.vmRenderControl1.TabIndex = 0;
            // 
            // buttonExecuteOnce
            // 
            this.buttonExecuteOnce.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonExecuteOnce.Location = new System.Drawing.Point(345, 125);
            this.buttonExecuteOnce.Name = "buttonExecuteOnce";
            this.buttonExecuteOnce.Size = new System.Drawing.Size(100, 30);
            this.buttonExecuteOnce.TabIndex = 58;
            this.buttonExecuteOnce.Text = "Run Once";
            this.buttonExecuteOnce.UseVisualStyleBackColor = true;
            this.buttonExecuteOnce.Click += new System.EventHandler(this.buttonExecuteOnce_Click);
            // 
            // groupBoxMsg
            // 
            this.groupBoxMsg.Controls.Add(this.buttonDeleteMsg);
            this.groupBoxMsg.Controls.Add(this.listBoxMsg);
            this.groupBoxMsg.Font = new System.Drawing.Font("Cambria", 9F);
            this.groupBoxMsg.Location = new System.Drawing.Point(591, 12);
            this.groupBoxMsg.Name = "groupBoxMsg";
            this.groupBoxMsg.Size = new System.Drawing.Size(500, 136);
            this.groupBoxMsg.TabIndex = 61;
            this.groupBoxMsg.TabStop = false;
            this.groupBoxMsg.Text = "Log";
            // 
            // buttonDeleteMsg
            // 
            this.buttonDeleteMsg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDeleteMsg.Location = new System.Drawing.Point(389, 13);
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
            this.listBoxMsg.Size = new System.Drawing.Size(477, 46);
            this.listBoxMsg.TabIndex = 0;
            // 
            // buttonGetResult
            // 
            this.buttonGetResult.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGetResult.Location = new System.Drawing.Point(460, 125);
            this.buttonGetResult.Name = "buttonGetResult";
            this.buttonGetResult.Size = new System.Drawing.Size(100, 30);
            this.buttonGetResult.TabIndex = 62;
            this.buttonGetResult.Text = "Get Result";
            this.buttonGetResult.UseVisualStyleBackColor = true;
            this.buttonGetResult.Click += new System.EventHandler(this.buttonGetResult_Click);
            // 
            // buttonParam
            // 
            this.buttonParam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonParam.Location = new System.Drawing.Point(230, 125);
            this.buttonParam.Name = "buttonParam";
            this.buttonParam.Size = new System.Drawing.Size(100, 30);
            this.buttonParam.TabIndex = 63;
            this.buttonParam.Text = "Param";
            this.buttonParam.UseVisualStyleBackColor = true;
            this.buttonParam.Click += new System.EventHandler(this.buttonParam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1104, 623);
            this.Controls.Add(this.buttonParam);
            this.Controls.Add(this.buttonGetResult);
            this.Controls.Add(this.groupBoxMsg);
            this.Controls.Add(this.buttonExecuteOnce);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxSolution);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBoxSolution.ResumeLayout(false);
            this.groupBoxSolution.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBoxMsg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSolution;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.ProgressBar progressBarSaveAndLoad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSolutionPath;
        private System.Windows.Forms.Button buttonChooseSoluPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLoadSolution;
        private System.Windows.Forms.Button buttonSaveSolution;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonExecuteOnce;
        private VMControls.Winform.Release.VmRenderControl vmRenderControl1;
        private System.Windows.Forms.GroupBox groupBoxMsg;
        private System.Windows.Forms.Button buttonDeleteMsg;
        private System.Windows.Forms.ListBox listBoxMsg;
        private System.Windows.Forms.Button buttonGetResult;
        private System.Windows.Forms.Button buttonParam;
        private VMControls.Winform.Release.VmParamsConfigWithRenderControl vmParamsConfigWithRenderControl1;
    }
}

