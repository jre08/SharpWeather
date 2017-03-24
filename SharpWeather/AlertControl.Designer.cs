namespace SharpWeather
{
    partial class AlertControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.alertType = new System.Windows.Forms.Label();
            this.alertMsg = new System.Windows.Forms.Label();
            this.alertImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.alertImg)).BeginInit();
            this.SuspendLayout();
            // 
            // alertType
            // 
            this.alertType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertType.Location = new System.Drawing.Point(3, 101);
            this.alertType.Name = "alertType";
            this.alertType.Size = new System.Drawing.Size(412, 23);
            this.alertType.TabIndex = 0;
            this.alertType.Text = "label1";
            this.alertType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // alertMsg
            // 
            this.alertMsg.Location = new System.Drawing.Point(6, 124);
            this.alertMsg.Name = "alertMsg";
            this.alertMsg.Size = new System.Drawing.Size(409, 463);
            this.alertMsg.TabIndex = 0;
            this.alertMsg.Text = "label1";
            // 
            // alertImg
            // 
            this.alertImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.alertImg.Location = new System.Drawing.Point(155, 15);
            this.alertImg.Name = "alertImg";
            this.alertImg.Size = new System.Drawing.Size(102, 68);
            this.alertImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alertImg.TabIndex = 1;
            this.alertImg.TabStop = false;
            // 
            // AlertControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.alertImg);
            this.Controls.Add(this.alertMsg);
            this.Controls.Add(this.alertType);
            this.Name = "AlertControl";
            this.Size = new System.Drawing.Size(418, 595);
            ((System.ComponentModel.ISupportInitialize)(this.alertImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label alertType;
        public System.Windows.Forms.Label alertMsg;
        public System.Windows.Forms.PictureBox alertImg;
    }
}
