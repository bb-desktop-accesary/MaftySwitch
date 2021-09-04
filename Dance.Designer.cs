namespace MaftySwitch
{
    partial class Dance
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
            this.DanceBox = new System.Windows.Forms.PictureBox();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.TitleBox = new System.Windows.Forms.PictureBox();
            this.MaftyLogoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DanceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaftyLogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DanceBox
            // 
            this.DanceBox.Location = new System.Drawing.Point(0, 0);
            this.DanceBox.Name = "DanceBox";
            this.DanceBox.Size = new System.Drawing.Size(1920, 1080);
            this.DanceBox.TabIndex = 1;
            this.DanceBox.TabStop = false;
            this.DanceBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DanceBox_Paint);
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(492, 685);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(1048, 360);
            this.TitleBox.TabIndex = 2;
            this.TitleBox.TabStop = false;
            this.TitleBox.Paint += new System.Windows.Forms.PaintEventHandler(this.TitleBox_Paint);
            // 
            // MaftyLogoBox
            // 
            this.MaftyLogoBox.Location = new System.Drawing.Point(1466, 12);
            this.MaftyLogoBox.Name = "MaftyLogoBox";
            this.MaftyLogoBox.Size = new System.Drawing.Size(442, 361);
            this.MaftyLogoBox.TabIndex = 3;
            this.MaftyLogoBox.TabStop = false;
            this.MaftyLogoBox.Paint += new System.Windows.Forms.PaintEventHandler(this.MaftyLogoBox_Paint);
            // 
            // Dance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.MaftyLogoBox);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.DanceBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dance";
            this.Text = "Dance";
            this.Load += new System.EventHandler(this.Dance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DanceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaftyLogoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox DanceBox;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.PictureBox TitleBox;
        private System.Windows.Forms.PictureBox MaftyLogoBox;
    }
}