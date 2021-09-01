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
        private Bitmap bmp;

        public Master()
        {
            InitializeComponent();
            master = this;
        }

        private void Master_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = this.BackColor;

            bmp = new Bitmap(@".\src\maf.gif");
            //bmp.MakeTransparent();
            picBox.Image = bmp;

        }

        public PictureBox getGawBox()
        {
            return this.picBox;
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
