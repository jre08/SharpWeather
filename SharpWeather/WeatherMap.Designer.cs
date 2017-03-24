/*
 * Created by SharpDevelop.
 * User: edenfield-john
 * Date: 1/25/2017
 * Time: 3:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SharpWeather
{
	partial class WeatherMap
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.PictureBox pictureMap;
		public System.Windows.Forms.TrackBar trackBarZoom;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureMap = new System.Windows.Forms.PictureBox();
			this.trackBarZoom = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.pictureMap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureMap
			// 
			this.pictureMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureMap.Location = new System.Drawing.Point(9, 1);
			this.pictureMap.Margin = new System.Windows.Forms.Padding(0);
			this.pictureMap.Name = "pictureMap";
			this.pictureMap.Size = new System.Drawing.Size(650, 425);
			this.pictureMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureMap.TabIndex = 0;
			this.pictureMap.TabStop = false;
			// 
			// trackBarZoom
			// 
			this.trackBarZoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.trackBarZoom.LargeChange = 50;
			this.trackBarZoom.Location = new System.Drawing.Point(173, 378);
			this.trackBarZoom.Maximum = 100;
			this.trackBarZoom.Minimum = 25;
			this.trackBarZoom.Name = "trackBarZoom";
			this.trackBarZoom.Size = new System.Drawing.Size(347, 45);
			this.trackBarZoom.SmallChange = 25;
			this.trackBarZoom.TabIndex = 1;
			this.trackBarZoom.TickFrequency = 25;
			this.trackBarZoom.Value = 25;
			this.trackBarZoom.Visible = false;
			//this.trackBarZoom.Scroll += new System.EventHandler(this.TrackBarZoomScroll);
			// 
			// WeatherMap
			// 
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.trackBarZoom);
			this.Controls.Add(this.pictureMap);
			this.Name = "WeatherMap";
			this.Size = new System.Drawing.Size(670, 430);
			((System.ComponentModel.ISupportInitialize)(this.pictureMap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
