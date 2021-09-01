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

        public Master()
        {
            InitializeComponent();
            master = this;
        }

        private void Master_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = this.BackColor;

            GawBox.Location = new Point(GawBox.Location.X - 300, GawBox.Location.Y);
            MafBox.Location = new Point(MafBox.Location.X + 500, MafBox.Location.Y);
            LaneBox.Location = new Point(LaneBox.Location.X, LaneBox.Location.Y + 1080);

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
            if(GawBox.Location.X < 70)
            {
                GawBox.Location = new Point(GawBox.Location.X + 10, GawBox.Location.Y);
            }else if(MafBox.Location.X > 1350)
            {
                MafBox.Location = new Point(MafBox.Location.X - 15, MafBox.Location.Y);
            }else if(LaneBox.Location.Y > 80)
            {
                LaneBox.Location = new Point(LaneBox.Location.X, LaneBox.Location.Y - 40);
            }

        }
    }
}
