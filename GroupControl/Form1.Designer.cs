namespace GroupControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vmRenderControl1 = new VMControls.Winform.Release.VmRenderControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vmParamsConfigWithRenderControl1 = new VMControls.Winform.Release.VmParamsConfigWithRenderControl();
            this.groupBoxMsg = new System.Windows.Forms.GroupBox();
            this.buttonDeleteMsg = new System.Windows.Forms.Button();
            this.listBoxMsg = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonBindParamControl = new System.Windows.Forms.Button();
            this.buttonExecuteOnce = new System.Windows.Forms.Button();
            this.buttonExportGroup = new System.Windows.Forms.Button();
            this.buttonChooseGroPath = new System.Windows.Forms.Button();
            this.textBoxGroPath = new System.Windows.Forms.TextBox();
            this.buttonImportGroup = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxMsg.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vmRenderControl1);
            this.groupBox1.Location = new System.Drawing.Point(734, 209);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(632, 561);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "结果渲染区";
            // 
            // vmRenderControl1
            // 
            this.vmRenderControl1.BackColor = System.Drawing.Color.Black;
            this.vmRenderControl1.ImageSource = null;
            this.vmRenderControl1.Location = new System.Drawing.Point(19, 26);
            this.vmRenderControl1.Margin = new System.Windows.Forms.Padding(5);
            this.vmRenderControl1.ModuleSource = null;
            this.vmRenderControl1.Name = "vmRenderControl1";
            this.vmRenderControl1.Size = new System.Drawing.Size(594, 518);
            this.vmRenderControl1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vmParamsConfigWithRenderControl1);
            this.groupBox2.Location = new System.Drawing.Point(15, 176);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(698, 594);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "参数配置区";
            // 
            // vmParamsConfigWithRenderControl1
            // 
            this.vmParamsConfigWithRenderControl1.BackColor = System.Drawing.Color.White;
            this.vmParamsConfigWithRenderControl1.ImageSource = null;
            this.vmParamsConfigWithRenderControl1.Location = new System.Drawing.Point(12, 26);
            this.vmParamsConfigWithRenderControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vmParamsConfigWithRenderControl1.ModuleSource = null;
            this.vmParamsConfigWithRenderControl1.Name = "vmParamsConfigWithRenderControl1";
            this.vmParamsConfigWithRenderControl1.ParamsConfig = null;
            this.vmParamsConfigWithRenderControl1.ROIVisible = true;
            this.vmParamsConfigWithRenderControl1.Size = new System.Drawing.Size(666, 551);
            this.vmParamsConfigWithRenderControl1.TabIndex = 11;
            // 
            // groupBoxMsg
            // 
            this.groupBoxMsg.Controls.Add(this.buttonDeleteMsg);
            this.groupBoxMsg.Controls.Add(this.listBoxMsg);
            this.groupBoxMsg.Font = new System.Drawing.Font("Cambria", 9F);
            this.groupBoxMsg.Location = new System.Drawing.Point(734, 15);
            this.groupBoxMsg.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxMsg.Name = "groupBoxMsg";
            this.groupBoxMsg.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxMsg.Size = new System.Drawing.Size(625, 170);
            this.groupBoxMsg.TabIndex = 62;
            this.groupBoxMsg.TabStop = false;
            this.groupBoxMsg.Text = "消息显示区";
            // 
            // buttonDeleteMsg
            // 
            this.buttonDeleteMsg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDeleteMsg.Location = new System.Drawing.Point(486, 16);
            this.buttonDeleteMsg.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteMsg.Name = "buttonDeleteMsg";
            this.buttonDeleteMsg.Size = new System.Drawing.Size(122, 38);
            this.buttonDeleteMsg.TabIndex = 1;
            this.buttonDeleteMsg.Text = "清空消息";
            this.buttonDeleteMsg.UseVisualStyleBackColor = true;
            this.buttonDeleteMsg.Click += new System.EventHandler(this.buttonDeleteMsg_Click);
            // 
            // listBoxMsg
            // 
            this.listBoxMsg.FormattingEnabled = true;
            this.listBoxMsg.ItemHeight = 17;
            this.listBoxMsg.Location = new System.Drawing.Point(12, 74);
            this.listBoxMsg.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMsg.Name = "listBoxMsg";
            this.listBoxMsg.Size = new System.Drawing.Size(595, 72);
            this.listBoxMsg.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonBindParamControl);
            this.groupBox3.Controls.Add(this.buttonExecuteOnce);
            this.groupBox3.Controls.Add(this.buttonExportGroup);
            this.groupBox3.Controls.Add(this.buttonChooseGroPath);
            this.groupBox3.Controls.Add(this.textBoxGroPath);
            this.groupBox3.Controls.Add(this.buttonImportGroup);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(698, 140);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Group操作";
            // 
            // buttonBindParamControl
            // 
            this.buttonBindParamControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBindParamControl.Location = new System.Drawing.Point(231, 79);
            this.buttonBindParamControl.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBindParamControl.Name = "buttonBindParamControl";
            this.buttonBindParamControl.Size = new System.Drawing.Size(125, 38);
            this.buttonBindParamControl.TabIndex = 21;
            this.buttonBindParamControl.Text = "绑定参数";
            this.buttonBindParamControl.UseVisualStyleBackColor = true;
            this.buttonBindParamControl.Click += new System.EventHandler(this.buttonBindParamControl_Click);
            // 
            // buttonExecuteOnce
            // 
            this.buttonExecuteOnce.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonExecuteOnce.Location = new System.Drawing.Point(380, 79);
            this.buttonExecuteOnce.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExecuteOnce.Name = "buttonExecuteOnce";
            this.buttonExecuteOnce.Size = new System.Drawing.Size(144, 38);
            this.buttonExecuteOnce.TabIndex = 20;
            this.buttonExecuteOnce.Text = "执行一次";
            this.buttonExecuteOnce.UseVisualStyleBackColor = true;
            this.buttonExecuteOnce.Click += new System.EventHandler(this.buttonExecuteOnce_Click);
            // 
            // buttonExportGroup
            // 
            this.buttonExportGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonExportGroup.Location = new System.Drawing.Point(548, 25);
            this.buttonExportGroup.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExportGroup.Name = "buttonExportGroup";
            this.buttonExportGroup.Size = new System.Drawing.Size(130, 38);
            this.buttonExportGroup.TabIndex = 19;
            this.buttonExportGroup.Text = "导出Group";
            this.buttonExportGroup.UseVisualStyleBackColor = true;
            this.buttonExportGroup.Click += new System.EventHandler(this.buttonExportGroup_Click);
            // 
            // buttonChooseGroPath
            // 
            this.buttonChooseGroPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonChooseGroPath.Location = new System.Drawing.Point(231, 25);
            this.buttonChooseGroPath.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChooseGroPath.Name = "buttonChooseGroPath";
            this.buttonChooseGroPath.Size = new System.Drawing.Size(125, 38);
            this.buttonChooseGroPath.TabIndex = 18;
            this.buttonChooseGroPath.Text = "选择Group路径";
            this.buttonChooseGroPath.UseVisualStyleBackColor = true;
            this.buttonChooseGroPath.Click += new System.EventHandler(this.buttonChooseGroPath_Click);
            // 
            // textBoxGroPath
            // 
            this.textBoxGroPath.Location = new System.Drawing.Point(12, 30);
            this.textBoxGroPath.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGroPath.Name = "textBoxGroPath";
            this.textBoxGroPath.Size = new System.Drawing.Size(196, 25);
            this.textBoxGroPath.TabIndex = 17;
            // 
            // buttonImportGroup
            // 
            this.buttonImportGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonImportGroup.Location = new System.Drawing.Point(380, 25);
            this.buttonImportGroup.Margin = new System.Windows.Forms.Padding(4);
            this.buttonImportGroup.Name = "buttonImportGroup";
            this.buttonImportGroup.Size = new System.Drawing.Size(144, 38);
            this.buttonImportGroup.TabIndex = 16;
            this.buttonImportGroup.Text = "导入Group";
            this.buttonImportGroup.UseVisualStyleBackColor = true;
            this.buttonImportGroup.Click += new System.EventHandler(this.buttonImportGroup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1381, 785);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxMsg);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GroupControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBoxMsg.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxMsg;
        private System.Windows.Forms.Button buttonDeleteMsg;
        private System.Windows.Forms.ListBox listBoxMsg;
        private VMControls.Winform.Release.VmRenderControl vmRenderControl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonExportGroup;
        private System.Windows.Forms.Button buttonChooseGroPath;
        private System.Windows.Forms.TextBox textBoxGroPath;
        private System.Windows.Forms.Button buttonImportGroup;
        private System.Windows.Forms.Button buttonExecuteOnce;
        private System.Windows.Forms.Button buttonBindParamControl;
        private VMControls.Winform.Release.VmParamsConfigWithRenderControl vmParamsConfigWithRenderControl1;
    }
}

