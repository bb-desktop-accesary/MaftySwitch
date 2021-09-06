using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaftySwitch
{
    class Ratio
    {
        private float rat;
        private const int def_W = 1920;
        private bool flag = true;

        //比率計算インスタンス
        public static Ratio pixRai;

        //コンストラクタ
        public Ratio(int screenW)
        {
            rat = /*0.7125f*/(float)screenW / def_W;

            //debug
            if (flag)
            {
                System.Windows.Forms.MessageBox.Show("width : " + screenW);
                System.Windows.Forms.MessageBox.Show("ratio : " + rat);
                flag = false;
            }

            pixRai = this;
        }

        //比率長さ計算
        public int calcLength(int oriLength)
        {
            int length;
            length = (int)(oriLength * rat);

            //debug
            System.Windows.Forms.MessageBox.Show("oriL * rat = " + length);

            return length;
        }
    }
}
