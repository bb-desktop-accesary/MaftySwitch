using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MaftySwitch
{
    public partial class Master : Form
    {
        private Bitmap gaw,lane,maf;
        private System.Media.SoundPlayer gawW, laneW, mafW;
        private bool SgawW, SlaneW, SmafW,Sdan;
        private int time = 0;
        private Dance dance;

        private Ratio pixRai;

        public Master()
        {
            InitializeComponent();
            this.pixRai = Ratio.pixRai;

            /*比率計算*/
            this.pixRai = new Ratio(Screen.GetBounds(this).Width);

            //set form size
            this.Width = this.pixRai.calcLength(1920);
            this.Height = this.pixRai.calcLength(1080);
            //set form location
            this.Location = new Point(0, Screen.GetBounds(this).Height - this.Height);

            //set box size and location
            this.pixRai.BoxAdjustSize(this.GawBox);
            this.pixRai.BoxAdjustSize(this.LaneBox);
            this.pixRai.BoxAdjustSize(this.MafBox);
        }

        private void Master_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = this.BackColor;
            this.SgawW = this.SlaneW = this.SmafW = this.Sdan =false;

            this.Width = Screen.GetBounds(this).Width;
            this.Height = Screen.GetBounds(this).Height;

            GawBox.Location = new Point(GawBox.Location.X - this.pixRai.calcLength(300), GawBox.Location.Y);
            MafBox.Location = new Point(MafBox.Location.X + this.pixRai.calcLength(600), MafBox.Location.Y);
            LaneBox.Location = new Point(LaneBox.Location.X, LaneBox.Location.Y + this.pixRai.calcLength(1080));

            gawW = new System.Media.SoundPlayer(@".\src\gaw.wav");
            gawW.Load();
            mafW = new System.Media.SoundPlayer(@".\src\maf.wav");
            mafW.Load();
            laneW = new System.Media.SoundPlayer(@".\src\lane.wav");
            laneW.Load();
            this.gaw = new Bitmap(@".\src\gaw.png");
            this.lane = new Bitmap(@".\src\lane.png");
            this.maf = new Bitmap(@".\src\maf.png");

            this.GawBox.Image = this.gaw;
            this.MafBox.Image = this.maf;
            this.LaneBox.Image = this.lane;

            updateTimer.Enabled = true;
        }

        public PictureBox getGawBox()
        {
            return this.GawBox;
        }

        private void GawBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(this.gaw, new Point(0,0));
        }

        private void LaneBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(this.lane, new Point(0,0));
        }

        private void MafBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(this.maf, new Point(0,0));
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (GawBox.Location.X < this.pixRai.calcLength(70))
            {
                GawBox.Location = new Point(GawBox.Location.X + this.pixRai.calcLength(10), GawBox.Location.Y);
                if (!SgawW)
                {
                    gawW.Play();
                    SgawW = true;
                }
            } else if (time < 140)
            {
                time++;
            }
            else if (MafBox.Location.X > this.pixRai.calcLength(1490))
            {
                MafBox.Location = new Point(MafBox.Location.X - this.pixRai.calcLength(15), MafBox.Location.Y);
                if (!SmafW)
                {
                    mafW.Play();
                    SmafW = true;
                }
            } else if (time < 200)
            {
                time++;
            }
            else if (LaneBox.Location.Y  > this.pixRai.calcLength(80))
            {
                LaneBox.Location = new Point(LaneBox.Location.X, LaneBox.Location.Y - this.pixRai.calcLength(40));
                if (!SlaneW)
                {
                    laneW.Play();
                    SlaneW = true;
                }
            }else if(time < 270)
            {
                time++;
            }
            else if(time == 270)
            {
                MafBox.Dispose();
                GawBox.Dispose();
                LaneBox.Dispose();

                gawW.Dispose();
                mafW.Dispose();
                laneW.Dispose();

                if (!Sdan)
                {
                    Sdan = true;
                    dance = new Dance();
                    dance.Show();
                }

                time++;
            }

        }
    }
}
