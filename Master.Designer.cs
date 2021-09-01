namespace MaftySwitch
{
    partial class Master
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GawBox = new System.Windows.Forms.PictureBox();
            this.LaneBox = new System.Windows.Forms.PictureBox();
            this.MafBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GawBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaneBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MafBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GawBox
            // 
            this.GawBox.Location = new System.Drawing.Point(72, 12);
            this.GawBox.Name = "GawBox";
            this.GawBox.Size = new System.Drawing.Size(600, 1080);
            this.GawBox.TabIndex = 0;
            this.GawBox.TabStop = false;
            this.GawBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GawBox_Paint);
            // 
            // LaneBox
            // 
            this.LaneBox.Location = new System.Drawing.Point(580, 75);
            this.LaneBox.Name = "LaneBox";
            this.LaneBox.Size = new System.Drawing.Size(600, 1080);
            this.LaneBox.TabIndex = 1;
            this.LaneBox.TabStop = false;
            this.LaneBox.Paint += new System.Windows.Forms.PaintEventHandler(this.LaneBox_Paint);
            // 
            // MafBox
            // 
            this.MafBox.Location = new System.Drawing.Point(1349, 75);
            this.MafBox.Name = "MafBox";
            this.MafBox.Size = new System.Drawing.Size(600, 1080);
            this.MafBox.TabIndex = 2;
            this.MafBox.TabStop = false;
            this.MafBox.Paint += new System.Windows.Forms.PaintEventHandler(this.MafBox_Paint);
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.MafBox);
            this.Controls.Add(this.LaneBox);
            this.Controls.Add(this.GawBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Master";
            this.Text = "Master";
            this.Activated += new System.EventHandler(this.Master_Activated);
            this.Load += new System.EventHandler(this.Master_Load);
            this.Shown += new System.EventHandler(this.Master_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.GawBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaneBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MafBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GawBox;
        private System.Windows.Forms.PictureBox LaneBox;
        private System.Windows.Forms.PictureBox MafBox;
        private System.Windows.Forms.Timer timer1;
    }
}

