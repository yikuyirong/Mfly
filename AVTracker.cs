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
    public partial class AVTracker : UserControl
    {

        private bool isDraging = false;

        private int x;

        private double length;


        /// <summary>
        /// AV时长
        /// </summary>
        public TimeSpan Length
        {
            get => TimeSpan.FromMilliseconds(length);
            set
            {
                length = value.TotalMilliseconds;

                this.lEnd.Text = value.ToString(@"hh\:mm\:ss");
            }
        }


        private double position;

        private void setPosition(double value)
        {
            Position = TimeSpan.FromMilliseconds(value);
        }

        public TimeSpan Position
        {
            get => TimeSpan.FromMilliseconds(position);

            set
            {
                if (position <= length)
                {
                    position = value.TotalMilliseconds;

                    this.lCenter.Text = value.ToString(@"hh\:mm\:ss");

                    if (!isDraging)
                    {
                        double bl = length == 0 ? 0 :  Math.Min(1, position / length);

                        this.btnPoint.Left = (int)(pTracker.Left + pTracker.Width * bl - btnPoint.Width / 2);
                    }
                }
            }
        }

        public AVTracker()
        {
            InitializeComponent();

            this.Length = TimeSpan.FromSeconds(100);

            this.btnPoint.Top = this.pTracker.Top + this.pTracker.Height / 2 - this.btnPoint.Height / 2;

            this.EnabledChanged += AVTracker_EnabledChanged;
        }

        private void AVTracker_EnabledChanged(object sender, EventArgs e)
        {
            this.btnPoint.Enabled = this.pTracker.Enabled = this.Enabled;

            if (this.Enabled == false)
            {
                this.Length = TimeSpan.Zero;
            }
        }

        private void btnPoint_MouseDown(object sender, MouseEventArgs e)
        {
            isDraging = true;

            this.x = e.X;
        }


        private void btnPoint_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraging)
            {
                int left = btnPoint.Left + e.X - this.x;

                int minLeft = pTracker.Left - btnPoint.Width / 2;

                int maxLeft = minLeft + pTracker.Width;

                this.btnPoint.Left = Math.Min(maxLeft, Math.Max(minLeft, left));

                double bl = (double)this.btnPoint.Left / (maxLeft - minLeft);

                this.setPosition(length * bl);
            }
        }

        private void btnPoint_MouseUp(object sender, MouseEventArgs e)
        {
            isDraging = false;
        }

        private void pTracker_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                setPosition(length * (e.X - this.pTracker.Left + btnPoint.Width) / this.pTracker.Width);
            }
            
        }
    }
}
