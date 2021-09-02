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
        public static Master master = null;
        private Bitmap gaw,lane,maf;
        private System.Media.SoundPlayer gawW, laneW, mafW;
        private bool SgawW, SlaneW, SmafW;
        private int time = 0;

        public Master()
        {
            InitializeComponent();
            master = this;
        }

        private void Master_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = this.BackColor;
            this.SgawW = this.SlaneW = this.SmafW = false;

            GawBox.Location = new Point(GawBox.Location.X - 300, GawBox.Location.Y);
            MafBox.Location = new Point(MafBox.Location.X + 500, MafBox.Location.Y);
            LaneBox.Location = new Point(LaneBox.Location.X, LaneBox.Location.Y + 1080);

            gawW = new System.Media.SoundPlayer(@".\src\gaw.wav");
            gawW.Load();
            mafW = new System.Media.SoundPlayer(@".\src\maf.wav");
            mafW.Load();
            laneW = new System.Media.SoundPlayer(@".\src\lane.wav");
            laneW.Load();

        }

        public PictureBox getGawBox()
        {
            return this.GawBox;
        }

        private void Master_Activated(object sender, EventArgs e)
        {
            
        }

        private void Master_Shown(object sender, EventArgs e)
        {
            
        }

        private void GawBox_Paint(object sender, PaintEventArgs e)
        {
            this.gaw = new Bitmap(@".\src\gaw.png");
            e.Graphics.DrawImage(this.gaw, new Point(0,0));
        }

        private void LaneBox_Paint(object sender, PaintEventArgs e)
        {
            this.lane = new Bitmap(@".\src\lane.png");
            e.Graphics.DrawImage(this.lane, new Point(0,0));
        }

        private void MafBox_Paint(object sender, PaintEventArgs e)
        {
            this.maf = new Bitmap(@".\src\maf.png");
            e.Graphics.DrawImage(this.maf, new Point(0,0));
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (GawBox.Location.X < 70)
            {
                GawBox.Location = new Point(GawBox.Location.X + 10, GawBox.Location.Y);
                if (!SgawW)
                {
                    gawW.Play();
                    SgawW = true;
                }
            } else if (time < 140)
            {
                time++;
            }
            else if (MafBox.Location.X > 1350)
            {
                MafBox.Location = new Point(MafBox.Location.X - 15, MafBox.Location.Y);
                if (!SmafW)
                {
                    mafW.Play();
                    SmafW = true;
                }
            } else if (time < 200)
            {
                time++;
            }
            else if (LaneBox.Location.Y > 80)
            {
                LaneBox.Location = new Point(LaneBox.Location.X, LaneBox.Location.Y - 40);
                if (!SlaneW)
                {
                    laneW.Play();
                    SlaneW = true;
                }
            }else if(time < 270)
            {
                time++;
            }
            else
            {
                MafBox.Dispose();
                GawBox.Dispose();
                LaneBox.Dispose();
            }

        }
    }
}
