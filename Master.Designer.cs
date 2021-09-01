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
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(0, 1);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(1921, 1080);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Master";
            this.Text = "Master";
            this.Activated += new System.EventHandler(this.Master_Activated);
            this.Load += new System.EventHandler(this.Master_Load);
            this.Shown += new System.EventHandler(this.Master_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
    }
}

