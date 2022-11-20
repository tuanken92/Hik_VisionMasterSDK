namespace FrontendControl
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxSolution = new System.Windows.Forms.GroupBox();
            this.buttonLoadSolution = new System.Windows.Forms.Button();
            this.buttonChooseSoluPath = new System.Windows.Forms.Button();
            this.progressBarSaveAndLoad = new System.Windows.Forms.ProgressBar();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxSolutionPath = new System.Windows.Forms.TextBox();
            this.labelProgress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxMsg = new System.Windows.Forms.GroupBox();
            this.listBoxMsg = new System.Windows.Forms.ListBox();
            this.buttonDeleteMsg = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vmFrontendControl1 = new VMControls.Winform.Release.VmFrontendControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.buttonExecuteOnce = new System.Windows.Forms.Button();
            this.buttonChangeSize2 = new System.Windows.Forms.Button();
            this.buttonChangeSize1 = new System.Windows.Forms.Button();
            this.buttonLoadFrontendData = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxSolution.SuspendLayout();
            this.groupBoxMsg.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSolution
            // 
            this.groupBoxSolution.Controls.Add(this.buttonLoadSolution);
            this.groupBoxSolution.Controls.Add(this.buttonChooseSoluPath);
            this.groupBoxSolution.Controls.Add(this.progressBarSaveAndLoad);
            this.groupBoxSolution.Controls.Add(this.textBoxPassword);
            this.groupBoxSolution.Controls.Add(this.textBoxSolutionPath);
            this.groupBoxSolution.Controls.Add(this.labelProgress);
            this.groupBoxSolution.Controls.Add(this.label3);
            this.groupBoxSolution.Controls.Add(this.label2);
            this.groupBoxSolution.Controls.Add(this.label1);
            this.groupBoxSolution.Location = new System.Drawing.Point(23, 14);
            this.groupBoxSolution.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSolution.Name = "groupBoxSolution";
            this.groupBoxSolution.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSolution.Size = new System.Drawing.Size(524, 154);
            this.groupBoxSolution.TabIndex = 0;
            this.groupBoxSolution.TabStop = false;
            this.groupBoxSolution.Text = "方案操作接口";
            // 
            // buttonLoadSolution
            // 
            this.buttonLoadSolution.Location = new System.Drawing.Point(388, 104);
            this.buttonLoadSolution.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoadSolution.Name = "buttonLoadSolution";
            this.buttonLoadSolution.Size = new System.Drawing.Size(123, 35);
            this.buttonLoadSolution.TabIndex = 7;
            this.buttonLoadSolution.Text = "加载方案";
            this.buttonLoadSolution.UseVisualStyleBackColor = true;
            this.buttonLoadSolution.Click += new System.EventHandler(this.buttonLoadSolution_Click);
            // 
            // buttonChooseSoluPath
            // 
            this.buttonChooseSoluPath.Location = new System.Drawing.Point(388, 25);
            this.buttonChooseSoluPath.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChooseSoluPath.Name = "buttonChooseSoluPath";
            this.buttonChooseSoluPath.Size = new System.Drawing.Size(123, 35);
            this.buttonChooseSoluPath.TabIndex = 7;
            this.buttonChooseSoluPath.Text = "选择方案路径";
            this.buttonChooseSoluPath.UseVisualStyleBackColor = true;
            this.buttonChooseSoluPath.Click += new System.EventHandler(this.buttonChooseSoluPath_Click);
            // 
            // progressBarSaveAndLoad
            // 
            this.progressBarSaveAndLoad.Location = new System.Drawing.Point(121, 106);
            this.progressBarSaveAndLoad.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarSaveAndLoad.Name = "progressBarSaveAndLoad";
            this.progressBarSaveAndLoad.Size = new System.Drawing.Size(248, 31);
            this.progressBarSaveAndLoad.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(120, 68);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(248, 25);
            this.textBoxPassword.TabIndex = 5;
            // 
            // textBoxSolutionPath
            // 
            this.textBoxSolutionPath.Location = new System.Drawing.Point(120, 29);
            this.textBoxSolutionPath.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSolutionPath.Name = "textBoxSolutionPath";
            this.textBoxSolutionPath.Size = new System.Drawing.Size(248, 25);
            this.textBoxSolutionPath.TabIndex = 4;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(88, 112);
            this.labelProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(15, 15);
            this.labelProgress.TabIndex = 3;
            this.labelProgress.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "进度：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "方案密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "方案路径：";
            // 
            // groupBoxMsg
            // 
            this.groupBoxMsg.Controls.Add(this.listBoxMsg);
            this.groupBoxMsg.Controls.Add(this.buttonDeleteMsg);
            this.groupBoxMsg.Location = new System.Drawing.Point(23, 331);
            this.groupBoxMsg.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxMsg.Name = "groupBoxMsg";
            this.groupBoxMsg.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxMsg.Size = new System.Drawing.Size(524, 219);
            this.groupBoxMsg.TabIndex = 1;
            this.groupBoxMsg.TabStop = false;
            this.groupBoxMsg.Text = "消息显示区";
            // 
            // listBoxMsg
            // 
            this.listBoxMsg.FormattingEnabled = true;
            this.listBoxMsg.ItemHeight = 15;
            this.listBoxMsg.Location = new System.Drawing.Point(28, 70);
            this.listBoxMsg.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMsg.Name = "listBoxMsg";
            this.listBoxMsg.Size = new System.Drawing.Size(481, 124);
            this.listBoxMsg.TabIndex = 3;
            // 
            // buttonDeleteMsg
            // 
            this.buttonDeleteMsg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDeleteMsg.Location = new System.Drawing.Point(380, 25);
            this.buttonDeleteMsg.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteMsg.Name = "buttonDeleteMsg";
            this.buttonDeleteMsg.Size = new System.Drawing.Size(131, 38);
            this.buttonDeleteMsg.TabIndex = 2;
            this.buttonDeleteMsg.Text = "清空消息";
            this.buttonDeleteMsg.UseVisualStyleBackColor = true;
            this.buttonDeleteMsg.Click += new System.EventHandler(this.buttonDeleteMsg_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.vmFrontendControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(881, 594);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "运行界面渲染区";
            // 
            // vmFrontendControl1
            // 
            this.vmFrontendControl1.AutoSize = true;
            this.vmFrontendControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vmFrontendControl1.Location = new System.Drawing.Point(4, 22);
            this.vmFrontendControl1.Margin = new System.Windows.Forms.Padding(5);
            this.vmFrontendControl1.Name = "vmFrontendControl1";
            this.vmFrontendControl1.Size = new System.Drawing.Size(873, 568);
            this.vmFrontendControl1.TabIndex = 0;
            this.vmFrontendControl1.SizeChanged += new System.EventHandler(this.vmFrontendControl1_SizeChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBoxControl);
            this.groupBox2.Controls.Add(this.buttonChangeSize2);
            this.groupBox2.Controls.Add(this.buttonChangeSize1);
            this.groupBox2.Controls.Add(this.buttonLoadFrontendData);
            this.groupBox2.Location = new System.Drawing.Point(23, 179);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(524, 145);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "运行界面控制区";
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Controls.Add(this.buttonExecuteOnce);
            this.groupBoxControl.Location = new System.Drawing.Point(411, 36);
            this.groupBoxControl.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxControl.Size = new System.Drawing.Size(96, 82);
            this.groupBoxControl.TabIndex = 32;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "单次执行";
            // 
            // buttonExecuteOnce
            // 
            this.buttonExecuteOnce.Image = ((System.Drawing.Image)(resources.GetObject("buttonExecuteOnce.Image")));
            this.buttonExecuteOnce.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonExecuteOnce.Location = new System.Drawing.Point(23, 25);
            this.buttonExecuteOnce.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExecuteOnce.Name = "buttonExecuteOnce";
            this.buttonExecuteOnce.Size = new System.Drawing.Size(48, 45);
            this.buttonExecuteOnce.TabIndex = 18;
            this.buttonExecuteOnce.UseVisualStyleBackColor = true;
            this.buttonExecuteOnce.Click += new System.EventHandler(this.buttonExecuteOnce_Click);
            // 
            // buttonChangeSize2
            // 
            this.buttonChangeSize2.Location = new System.Drawing.Point(188, 91);
            this.buttonChangeSize2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChangeSize2.Name = "buttonChangeSize2";
            this.buttonChangeSize2.Size = new System.Drawing.Size(123, 35);
            this.buttonChangeSize2.TabIndex = 7;
            this.buttonChangeSize2.Text = "窗口放大";
            this.buttonChangeSize2.UseVisualStyleBackColor = true;
            this.buttonChangeSize2.Click += new System.EventHandler(this.buttonChangeSize2_Click);
            // 
            // buttonChangeSize1
            // 
            this.buttonChangeSize1.Location = new System.Drawing.Point(28, 91);
            this.buttonChangeSize1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChangeSize1.Name = "buttonChangeSize1";
            this.buttonChangeSize1.Size = new System.Drawing.Size(123, 35);
            this.buttonChangeSize1.TabIndex = 7;
            this.buttonChangeSize1.Text = "窗口缩小";
            this.buttonChangeSize1.UseVisualStyleBackColor = true;
            this.buttonChangeSize1.Click += new System.EventHandler(this.buttonChangeSize1_Click);
            // 
            // buttonLoadFrontendData
            // 
            this.buttonLoadFrontendData.Location = new System.Drawing.Point(28, 36);
            this.buttonLoadFrontendData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoadFrontendData.Name = "buttonLoadFrontendData";
            this.buttonLoadFrontendData.Size = new System.Drawing.Size(123, 35);
            this.buttonLoadFrontendData.TabIndex = 7;
            this.buttonLoadFrontendData.Text = "加载界面数据";
            this.buttonLoadFrontendData.UseVisualStyleBackColor = true;
            this.buttonLoadFrontendData.Click += new System.EventHandler(this.buttonLoadFrontendData_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxSolution);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxMsg);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1463, 594);
            this.splitContainer1.SplitterDistance = 577;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1463, 594);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FrontendControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSolution.ResumeLayout(false);
            this.groupBoxSolution.PerformLayout();
            this.groupBoxMsg.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxControl.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSolution;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxMsg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLoadSolution;
        private System.Windows.Forms.Button buttonChooseSoluPath;
        private System.Windows.Forms.ProgressBar progressBarSaveAndLoad;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxSolutionPath;
        private System.Windows.Forms.ListBox listBoxMsg;
        private System.Windows.Forms.Button buttonDeleteMsg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonChangeSize2;
        private System.Windows.Forms.Button buttonChangeSize1;
        private System.Windows.Forms.Button buttonLoadFrontendData;
        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.Button buttonExecuteOnce;
        private VMControls.Winform.Release.VmFrontendControl vmFrontendControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

