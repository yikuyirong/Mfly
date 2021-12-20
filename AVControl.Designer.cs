namespace Mfly
{
    partial class AVControl
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
            this.avTracker = new Mfly.AVTracker();
            this.btnPlay = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.SuspendLayout();
            // 
            // avTracker
            // 
            this.avTracker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.avTracker.Length = System.TimeSpan.Parse("00:01:40");
            this.avTracker.Location = new System.Drawing.Point(79, 3);
            this.avTracker.Name = "avTracker";
            this.avTracker.Position = System.TimeSpan.Parse("00:00:00");
            this.avTracker.Size = new System.Drawing.Size(879, 51);
            this.avTracker.TabIndex = 2;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(3, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(70, 51);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Values.ImageStates.ImageCheckedNormal = global::Mfly.Properties.Resources._22_18_;
            this.btnPlay.Values.ImageStates.ImageNormal = global::Mfly.Properties.Resources._08_41_;
            this.btnPlay.Values.Text = "";
            this.btnPlay.CheckedChanged += new System.EventHandler(this.btnPlay_CheckedChanged);
            // 
            // AVControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.avTracker);
            this.Name = "AVControl";
            this.Size = new System.Drawing.Size(961, 59);
            this.ResumeLayout(false);

        }

        #endregion
        private AVTracker avTracker;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnPlay;
    }
}
