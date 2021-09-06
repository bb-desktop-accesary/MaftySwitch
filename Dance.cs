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
        //timer
        private int time = 0;
        private Ratio pixRai;

        public Dance()
        {
            InitializeComponent();

            this.pixRai = Ratio.pixRai;

            /*比率設定*/

            //form
            //MessageBox.Show("defolt width = " + 1920);
            this.Width = this.pixRai.calcLength(1920);
            //MessageBox.Show("defolt height = " + 1080);
            this.Height = this.pixRai.calcLength(1080);

            this.Location = new Point(0, Screen.GetBounds(this).Height - this.Height);

            //dance
            //MessageBox.Show("DanceBox"); //debug
            this.pixRai.BoxAdjustSize(DanceBox);

            //logo
            //MessageBox.Show("MaftyLogoBox"); //debug
            this.pixRai.BoxAdjustSize(MaftyLogoBox);

            //title
            //MessageBox.Show("TitleBox"); //debug
            this.pixRai.BoxAdjustSize(TitleBox);
        }
        private void Dance_Load(object sender, EventArgs e)
        {
            //初期設定
            //透明化
            this.TransparencyKey = this.BackColor;

            //set up timer
            UpdateTimer.Enabled = true;

            //set images size


            //set dance
            img = new Bitmap(@".\src\dance_only.gif");
            DanceBox.Image = img;

            //set png
            MaftyLogoBox.Image = new Bitmap(@".\src\mafty.png");
            TitleBox.Image = new Bitmap(@".\src\hasawei.png");

            //move gif
            //DanceBox.Paint += DanceBox_Paint;
            ImageAnimator.Animate(img, new EventHandler(Image_FrameChanged));

            //sound 
            player = new SoundPlayer(@".\src\senkou.wav");
            player.Load();
        }
        // このアクションがあると別枠に入れ始める。
        /*private void DanceBox_Paint(object sender, PaintEventArgs e)
        {
            ImageAnimator.UpdateFrames(img);
            e.Graphics.DrawImage(img, new Point(0, 0));
        }*/

        private void Image_FrameChanged(object o, EventArgs e)
        {
            DanceBox.Invalidate();
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

        //TitleBox
        private void TitleBox_Paint(object sender, PaintEventArgs e)
        {
            TitleBox.BackColor = Color.Transparent;
            TitleBox.Parent = DanceBox;
        }

        /*//Adjust Size PictureBoxes
        private void BoxAdjustSize(PictureBox box)
        {
            MessageBox.Show("box width = " + box.Width); //debug
            box.Width = this.pixRai.calcLength(box.Width);
            MessageBox.Show("box height = " + box.Height); //debug
            box.Height = this.pixRai.calcLength(box.Height);
            MessageBox.Show("box point = " + box.Location.X + "," + box.Location.Y);
            box.Location = new Point(this.pixRai.calcLength(box.Location.X), this.pixRai.calcLength(box.Location.Y));
        }*/
    }
}
