﻿using System;
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

        public Master()
        {
            InitializeComponent();
            master = this;
        }

        private void Master_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = this.BackColor;

            GawBox.ImageLocation = @".\src\gaw.png";
            GawBox.SizeMode = PictureBoxSizeMode.Normal;

            MafBox.ImageLocation = @".\src\maf.png";
            MafBox.SizeMode = PictureBoxSizeMode.Normal;

            LaneBox.ImageLocation = @".\src\lane.png";
            LaneBox.SizeMode = PictureBoxSizeMode.Normal;

            GawBox.Location = new Point(GawBox.Location.X + 1, GawBox.Location.Y);

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
            MaftySwitch.Move.moveGaw();
        }
    }
}
