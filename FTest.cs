using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mfly
{
    public partial class Form1 : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public Form1()
        {
            InitializeComponent();

            this.avControl1.SetPlayStatus(EPlayStatus.停止);

            this.avControl1.OnPlayStatus += AvControl1_OnPlayStatus;

            this.vlcControl1.TimeChanged += VlcControl1_TimeChanged;

        }

        private void VlcControl1_TimeChanged(object sender, Vlc.DotNet.Core.VlcMediaPlayerTimeChangedEventArgs e)
        {
            this.avControl1.SetPlayStatus(EPlayStatus.位置, TimeSpan.FromMilliseconds(e.NewTime));
        }

        private void VlcControl1_PositionChanged(object sender, Vlc.DotNet.Core.VlcMediaPlayerPositionChangedEventArgs e)
        {
            //e.NewPosition
            //throw new NotImplementedException();
        }

        private void AvControl1_OnPlayStatus(object sender, Hungsum.Sys.Utility.HsEventArgs<EPlayStatus, object> e)
        {
            try
            {
                if (e.Data == EPlayStatus.开始)
                {
                    OpenFileDialog ofd = new OpenFileDialog();

                    ofd.Filter = "mp4文件|*.mp4";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        ofd.FileName = ofd.FileName;

                        using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                        {
                            vlcControl1.Play(fs);
                        }
                    }

                }
                else if (e.Data == EPlayStatus.停止)
                {

                }
                else if (e.Data == EPlayStatus.位置)
                { 
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void VlcControl1_VlcLibDirectoryNeeded(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e)
        {
            if (Environment.Is64BitOperatingSystem)
            {
                e.VlcLibDirectory = new DirectoryInfo(Path.GetFullPath(@"..\libvlc\win-x86\"));
            }
            else
            {
                e.VlcLibDirectory = new DirectoryInfo(Path.GetFullPath(@"..\libvlc\win-x64\"));
            }
        }
    }
}
