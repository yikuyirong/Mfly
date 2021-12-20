namespace Mfly
{
    partial class AVTracker
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lStart = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pTracker = new System.Windows.Forms.Panel();
            this.btnPoint = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lEnd = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lCenter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // lStart
            // 
            this.lStart.Location = new System.Drawing.Point(0, 0);
            this.lStart.Name = "lStart";
            this.lStart.Size = new System.Drawing.Size(56, 20);
            this.lStart.TabIndex = 0;
            this.lStart.Values.Text = "00:00:00";
            // 
            // pTracker
            // 
            this.pTracker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pTracker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(194)))), ((int)(((byte)(219)))));
            this.pTracker.Location = new System.Drawing.Point(10, 26);
            this.pTracker.Name = "pTracker";
            this.pTracker.Size = new System.Drawing.Size(501, 11);
            this.pTracker.TabIndex = 6;
            this.pTracker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pTracker_MouseClick);
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(238, 21);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(12, 24);
            this.btnPoint.TabIndex = 7;
            this.btnPoint.Values.Text = "";
            this.btnPoint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPoint_MouseDown);
            this.btnPoint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPoint_MouseMove);
            this.btnPoint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnPoint_MouseUp);
            // 
            // lEnd
            // 
            this.lEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lEnd.Location = new System.Drawing.Point(466, 0);
            this.lEnd.Name = "lEnd";
            this.lEnd.Size = new System.Drawing.Size(56, 20);
            this.lEnd.TabIndex = 8;
            this.lEnd.Values.Text = "00:00:00";
            // 
            // lCenter
            // 
            this.lCenter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lCenter.Location = new System.Drawing.Point(233, 0);
            this.lCenter.Name = "lCenter";
            this.lCenter.Size = new System.Drawing.Size(56, 20);
            this.lCenter.TabIndex = 9;
            this.lCenter.Values.Text = "00:00:00";
            // 
            // AVTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lCenter);
            this.Controls.Add(this.lEnd);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.pTracker);
            this.Controls.Add(this.lStart);
            this.Name = "AVTracker";
            this.Size = new System.Drawing.Size(524, 51);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel lStart;
        private System.Windows.Forms.Panel pTracker;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPoint;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lEnd;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lCenter;
    }
}
