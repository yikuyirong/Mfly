namespace Mfly
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kryptonWorkspaceSequence1 = new ComponentFactory.Krypton.Workspace.KryptonWorkspaceSequence();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonCheckBox2 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBox1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.avControl1 = new Mfly.AVControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // kryptonWorkspaceSequence1
            // 
            this.kryptonWorkspaceSequence1.UniqueName = "9DC510B444EB41CD2E805C4CAB572AB6";
            this.kryptonWorkspaceSequence1.WorkspaceControl = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kryptonCheckBox2);
            this.panel1.Controls.Add(this.kryptonCheckBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.avControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 439);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(993, 83);
            this.panel1.TabIndex = 2;
            // 
            // kryptonCheckBox2
            // 
            this.kryptonCheckBox2.Location = new System.Drawing.Point(95, 42);
            this.kryptonCheckBox2.Name = "kryptonCheckBox2";
            this.kryptonCheckBox2.Size = new System.Drawing.Size(75, 20);
            this.kryptonCheckBox2.TabIndex = 6;
            this.kryptonCheckBox2.Values.Text = "副屏显示";
            // 
            // kryptonCheckBox1
            // 
            this.kryptonCheckBox1.Location = new System.Drawing.Point(14, 42);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
            this.kryptonCheckBox1.Size = new System.Drawing.Size(75, 20);
            this.kryptonCheckBox1.TabIndex = 5;
            this.kryptonCheckBox1.Values.Text = "循环播放";
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vlcControl1.Location = new System.Drawing.Point(0, 0);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(993, 439);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 3;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = null;
            this.vlcControl1.VlcMediaplayerOptions = null;
            this.vlcControl1.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.VlcControl1_VlcLibDirectoryNeeded);
            // 
            // avControl1
            // 
            this.avControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.avControl1.Location = new System.Drawing.Point(176, 13);
            this.avControl1.Name = "avControl1";
            this.avControl1.Size = new System.Drawing.Size(804, 67);
            this.avControl1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 522);
            this.Controls.Add(this.vlcControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "FTest";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private ComponentFactory.Krypton.Workspace.KryptonWorkspaceSequence kryptonWorkspaceSequence1;
        private System.Windows.Forms.Panel panel1;
        private AVControl avControl1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox2;
    }
}

