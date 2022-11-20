namespace ProcessControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxProcessName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExportProcess = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProcessPath = new System.Windows.Forms.TextBox();
            this.buttonChoosePrcPath = new System.Windows.Forms.Button();
            this.buttonImportProcess = new System.Windows.Forms.Button();
            this.buttonDeleteProcess = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vmProcedureConfigControl1 = new VMControls.Winform.Release.VmProcedureConfigControl();
            this.groupBoxMsg = new System.Windows.Forms.GroupBox();
            this.buttonDeleteMsg = new System.Windows.Forms.Button();
            this.listBoxMsg = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonShieldProcess = new System.Windows.Forms.Button();
            this.groupBoxTimeInterval = new System.Windows.Forms.GroupBox();
            this.textBoxTimeInterval = new System.Windows.Forms.TextBox();
            this.buttonSetTimeInterval = new System.Windows.Forms.Button();
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.buttonStopExecute = new System.Windows.Forms.Button();
            this.buttonExecuteOnce = new System.Windows.Forms.Button();
            this.buttonContinuExecute = new System.Windows.Forms.Button();
            this.groupBoxSolution.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxMsg.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBoxTimeInterval.SuspendLayout();
            this.groupBoxControl.SuspendLayout();
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
            this.groupBoxSolution.TabIndex = 52;
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
            this.buttonChooseSoluPath.Text = "Select";
            this.buttonChooseSoluPath.UseVisualStyleBackColor = true;
            this.buttonChooseSoluPath.Click += new System.EventHandler(this.buttonChooseSoluPath_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(383, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 14);
            this.label8.TabIndex = 12;
            this.label8.Text = "Pass：";
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
            this.label11.Size = new System.Drawing.Size(37, 14);
            this.label11.TabIndex = 9;
            this.label11.Text = "Prog：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxProcessName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonExportProcess);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxProcessPath);
            this.groupBox2.Controls.Add(this.buttonChoosePrcPath);
            this.groupBox2.Controls.Add(this.buttonImportProcess);
            this.groupBox2.Controls.Add(this.buttonDeleteProcess);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 9F);
            this.groupBox2.Location = new System.Drawing.Point(12, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 106);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Process";
            // 
            // textBoxProcessName
            // 
            this.textBoxProcessName.Location = new System.Drawing.Point(114, 69);
            this.textBoxProcessName.Name = "textBoxProcessName";
            this.textBoxProcessName.Size = new System.Drawing.Size(204, 22);
            this.textBoxProcessName.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(14, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 14);
            this.label1.TabIndex = 17;
            this.label1.Text = "Producer Name：";
            // 
            // buttonExportProcess
            // 
            this.buttonExportProcess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonExportProcess.Location = new System.Drawing.Point(333, 65);
            this.buttonExportProcess.Name = "buttonExportProcess";
            this.buttonExportProcess.Size = new System.Drawing.Size(100, 30);
            this.buttonExportProcess.TabIndex = 16;
            this.buttonExportProcess.Text = "Export Process";
            this.buttonExportProcess.UseVisualStyleBackColor = true;
            this.buttonExportProcess.Click += new System.EventHandler(this.buttonExportProcess_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(9, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Prc path：";
            // 
            // textBoxProcessPath
            // 
            this.textBoxProcessPath.Location = new System.Drawing.Point(114, 23);
            this.textBoxProcessPath.Name = "textBoxProcessPath";
            this.textBoxProcessPath.Size = new System.Drawing.Size(204, 22);
            this.textBoxProcessPath.TabIndex = 10;
            // 
            // buttonChoosePrcPath
            // 
            this.buttonChoosePrcPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonChoosePrcPath.Location = new System.Drawing.Point(333, 18);
            this.buttonChoosePrcPath.Name = "buttonChoosePrcPath";
            this.buttonChoosePrcPath.Size = new System.Drawing.Size(100, 30);
            this.buttonChoosePrcPath.TabIndex = 11;
            this.buttonChoosePrcPath.Text = "Choose Prc Path";
            this.buttonChoosePrcPath.UseVisualStyleBackColor = true;
            this.buttonChoosePrcPath.Click += new System.EventHandler(this.buttonChoosePrcPath_Click);
            // 
            // buttonImportProcess
            // 
            this.buttonImportProcess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonImportProcess.Location = new System.Drawing.Point(448, 18);
            this.buttonImportProcess.Name = "buttonImportProcess";
            this.buttonImportProcess.Size = new System.Drawing.Size(100, 30);
            this.buttonImportProcess.TabIndex = 15;
            this.buttonImportProcess.Text = "Import Process";
            this.buttonImportProcess.UseVisualStyleBackColor = true;
            this.buttonImportProcess.Click += new System.EventHandler(this.buttonImportProcess_Click);
            // 
            // buttonDeleteProcess
            // 
            this.buttonDeleteProcess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDeleteProcess.Location = new System.Drawing.Point(448, 64);
            this.buttonDeleteProcess.Name = "buttonDeleteProcess";
            this.buttonDeleteProcess.Size = new System.Drawing.Size(100, 30);
            this.buttonDeleteProcess.TabIndex = 14;
            this.buttonDeleteProcess.Text = "Del";
            this.buttonDeleteProcess.UseVisualStyleBackColor = true;
            this.buttonDeleteProcess.Click += new System.EventHandler(this.buttonDeleteProcess_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vmProcedureConfigControl1);
            this.groupBox1.Location = new System.Drawing.Point(587, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 532);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "流程配置区";
            // 
            // vmProcedureConfigControl1
            // 
            this.vmProcedureConfigControl1.Location = new System.Drawing.Point(14, 20);
            this.vmProcedureConfigControl1.Margin = new System.Windows.Forms.Padding(2);
            this.vmProcedureConfigControl1.Name = "vmProcedureConfigControl1";
            this.vmProcedureConfigControl1.Size = new System.Drawing.Size(537, 499);
            this.vmProcedureConfigControl1.TabIndex = 0;
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            // 
            // groupBoxMsg
            // 
            this.groupBoxMsg.Controls.Add(this.buttonDeleteMsg);
            this.groupBoxMsg.Controls.Add(this.listBoxMsg);
            this.groupBoxMsg.Font = new System.Drawing.Font("Cambria", 9F);
            this.groupBoxMsg.Location = new System.Drawing.Point(12, 369);
            this.groupBoxMsg.Name = "groupBoxMsg";
            this.groupBoxMsg.Size = new System.Drawing.Size(558, 175);
            this.groupBoxMsg.TabIndex = 60;
            this.groupBoxMsg.TabStop = false;
            this.groupBoxMsg.Text = "Log";
            // 
            // buttonDeleteMsg
            // 
            this.buttonDeleteMsg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDeleteMsg.Location = new System.Drawing.Point(447, 21);
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
            this.listBoxMsg.Size = new System.Drawing.Size(535, 88);
            this.listBoxMsg.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBoxTimeInterval);
            this.groupBox3.Controls.Add(this.groupBoxControl);
            this.groupBox3.Location = new System.Drawing.Point(12, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(557, 110);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Main";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonShieldProcess);
            this.groupBox4.Location = new System.Drawing.Point(389, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(159, 77);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "流程禁用";
            // 
            // buttonShieldProcess
            // 
            this.buttonShieldProcess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonShieldProcess.Location = new System.Drawing.Point(15, 28);
            this.buttonShieldProcess.Name = "buttonShieldProcess";
            this.buttonShieldProcess.Size = new System.Drawing.Size(127, 33);
            this.buttonShieldProcess.TabIndex = 31;
            this.buttonShieldProcess.Text = "禁用流程";
            this.buttonShieldProcess.UseVisualStyleBackColor = true;
            this.buttonShieldProcess.Click += new System.EventHandler(this.buttonShieldProcess_Click);
            // 
            // groupBoxTimeInterval
            // 
            this.groupBoxTimeInterval.Controls.Add(this.textBoxTimeInterval);
            this.groupBoxTimeInterval.Controls.Add(this.buttonSetTimeInterval);
            this.groupBoxTimeInterval.Location = new System.Drawing.Point(209, 11);
            this.groupBoxTimeInterval.Name = "groupBoxTimeInterval";
            this.groupBoxTimeInterval.Size = new System.Drawing.Size(141, 93);
            this.groupBoxTimeInterval.TabIndex = 35;
            this.groupBoxTimeInterval.TabStop = false;
            this.groupBoxTimeInterval.Text = "Time Interval";
            // 
            // textBoxTimeInterval
            // 
            this.textBoxTimeInterval.Location = new System.Drawing.Point(12, 21);
            this.textBoxTimeInterval.Name = "textBoxTimeInterval";
            this.textBoxTimeInterval.Size = new System.Drawing.Size(117, 20);
            this.textBoxTimeInterval.TabIndex = 35;
            // 
            // buttonSetTimeInterval
            // 
            this.buttonSetTimeInterval.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSetTimeInterval.Location = new System.Drawing.Point(12, 53);
            this.buttonSetTimeInterval.Name = "buttonSetTimeInterval";
            this.buttonSetTimeInterval.Size = new System.Drawing.Size(117, 33);
            this.buttonSetTimeInterval.TabIndex = 31;
            this.buttonSetTimeInterval.Text = "Set Time Interval";
            this.buttonSetTimeInterval.UseVisualStyleBackColor = true;
            this.buttonSetTimeInterval.Click += new System.EventHandler(this.buttonSetTimeInterval_Click);
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Controls.Add(this.buttonStopExecute);
            this.groupBoxControl.Controls.Add(this.buttonExecuteOnce);
            this.groupBoxControl.Controls.Add(this.buttonContinuExecute);
            this.groupBoxControl.Location = new System.Drawing.Point(14, 29);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(178, 66);
            this.groupBoxControl.TabIndex = 31;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "Run";
            // 
            // buttonStopExecute
            // 
            this.buttonStopExecute.Image = ((System.Drawing.Image)(resources.GetObject("buttonStopExecute.Image")));
            this.buttonStopExecute.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonStopExecute.Location = new System.Drawing.Point(130, 20);
            this.buttonStopExecute.Name = "buttonStopExecute";
            this.buttonStopExecute.Size = new System.Drawing.Size(36, 36);
            this.buttonStopExecute.TabIndex = 19;
            this.buttonStopExecute.UseVisualStyleBackColor = true;
            this.buttonStopExecute.Click += new System.EventHandler(this.buttonStopExecute_Click);
            // 
            // buttonExecuteOnce
            // 
            this.buttonExecuteOnce.Image = ((System.Drawing.Image)(resources.GetObject("buttonExecuteOnce.Image")));
            this.buttonExecuteOnce.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonExecuteOnce.Location = new System.Drawing.Point(12, 20);
            this.buttonExecuteOnce.Name = "buttonExecuteOnce";
            this.buttonExecuteOnce.Size = new System.Drawing.Size(36, 36);
            this.buttonExecuteOnce.TabIndex = 18;
            this.buttonExecuteOnce.UseVisualStyleBackColor = true;
            this.buttonExecuteOnce.Click += new System.EventHandler(this.buttonExecuteOnce_Click);
            // 
            // buttonContinuExecute
            // 
            this.buttonContinuExecute.Image = ((System.Drawing.Image)(resources.GetObject("buttonContinuExecute.Image")));
            this.buttonContinuExecute.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonContinuExecute.Location = new System.Drawing.Point(71, 20);
            this.buttonContinuExecute.Name = "buttonContinuExecute";
            this.buttonContinuExecute.Size = new System.Drawing.Size(36, 36);
            this.buttonContinuExecute.TabIndex = 20;
            this.buttonContinuExecute.UseVisualStyleBackColor = true;
            this.buttonContinuExecute.Click += new System.EventHandler(this.buttonContinuExecute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1166, 554);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxMsg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxSolution);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSolution.ResumeLayout(false);
            this.groupBoxSolution.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxMsg.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBoxTimeInterval.ResumeLayout(false);
            this.groupBoxTimeInterval.PerformLayout();
            this.groupBoxControl.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxProcessPath;
        private System.Windows.Forms.Button buttonChoosePrcPath;
        private System.Windows.Forms.Button buttonImportProcess;
        private System.Windows.Forms.Button buttonDeleteProcess;
        private System.Windows.Forms.Button buttonExportProcess;
        private System.Windows.Forms.GroupBox groupBox1;
        private VMControls.Winform.Release.VmProcedureConfigControl vmProcedureConfigControl1;
        private System.Windows.Forms.GroupBox groupBoxMsg;
        private System.Windows.Forms.Button buttonDeleteMsg;
        private System.Windows.Forms.ListBox listBoxMsg;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonShieldProcess;
        internal System.Windows.Forms.GroupBox groupBoxTimeInterval;
        private System.Windows.Forms.TextBox textBoxTimeInterval;
        private System.Windows.Forms.Button buttonSetTimeInterval;
        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.Button buttonStopExecute;
        private System.Windows.Forms.Button buttonExecuteOnce;
        private System.Windows.Forms.Button buttonContinuExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProcessName;
    }
}

