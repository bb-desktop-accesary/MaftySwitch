using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MaftySwitch
{
    public partial class Dance : Form
    {
        private Bitmap img;
        private SoundPlayer player;
        private int time = 0;
        public Dance()
        {
            InitializeComponent();
        }

        private void DanceBox_Paint(object sender, PaintEventArgs e)
        {
            ImageAnimator.UpdateFrames(img);
            e.Graphics.DrawImage(img, new Point(0, 0));
        }

        private void Image_FrameChanged(object o, EventArgs e)
        {
            DanceBox.Invalidate();
        }

        private void Dance_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = this.BackColor;
            this.Width = Screen.GetBounds(this).Width;
            this.Height = Screen.GetBounds(this).Height;

            UpdateTimer.Enabled = true;
            img = new Bitmap(@".\src\dance_only.gif");

            DanceBox.Image = img;

            DanceBox.Paint += DanceBox_Paint;

            ImageAnimator.Animate(img, new EventHandler(Image_FrameChanged));

            player = new SoundPlayer(@".\src\senkou.wav");
            player.Load();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (time == 0)
            {
                player.Play();
                time++;
            }
            else if (time < 89)
            {
                time++;
            }
            else
            {
                player.Stop();
                player.Dispose();
                Application.Exit();
            }
        }

        private void MaftyLogoBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap(@".\src\mafty.png"), new Point(0, 0));
        }

        private void TitleBox_Paint(object sender, PaintEventArgs e)
        {
            TitleBox.BackColor = Color.Transparent;
            TitleBox.Parent = DanceBox;
            e.Graphics.DrawImage(new Bitmap(@".\src\hasawei.png"), new Point(0, 0));
        }
    }
}
