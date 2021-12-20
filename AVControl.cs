using Hungsum.Sys.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mfly
{
    public partial class AVControl : UserControl
    {
        public event EventHandler<HsEventArgs<EPlayStatus, object>> OnPlayStatus;

        public AVControl()
        {
            InitializeComponent();
        }

        public void SetPlayStatus(EPlayStatus status,object data = null)
        {
            if (status == EPlayStatus.开始)
            {
                this.avTracker.Enabled = true;
                this.btnPlay.Checked = true;
            }
            else if (status == EPlayStatus.停止)
            {
                this.avTracker.Enabled = false;
                this.btnPlay.Checked = false;
            }
            else if (status == EPlayStatus.位置)
            {
                if (data != null)
                {
                    this.avTracker.Position = (TimeSpan)data;
                }
            }
        }

        private void dispatchPlayStatusEvent(EPlayStatus status, object data = null)
        {
            this.OnPlayStatus?.Invoke(this, new HsEventArgs<EPlayStatus, object>(status, data));
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //this.dispatchPlayStatusEvent(this.btnPlay.Checked ? EPlayStatus.开始);
        }

        private void btnPlay_CheckedChanged(object sender, EventArgs e)
        {
            this.dispatchPlayStatusEvent(this.btnPlay.Checked ? EPlayStatus.开始 : EPlayStatus.停止);
           

        }
    }
}
