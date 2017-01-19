/*
 * Created by SharpDevelop.
 * User: 6g1w
 * Date: 2012-08-06
 * Time: 15:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Rainmeter
{
	partial class About
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
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
			this.btnClose = new System.Windows.Forms.Button();
			this.lblAbout = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(185, 97);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "OK";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.Btn_CloseClick);
			// 
			// lblAbout
			// 
			this.lblAbout.Location = new System.Drawing.Point(12, 9);
			this.lblAbout.Name = "lblAbout";
			this.lblAbout.Size = new System.Drawing.Size(248, 74);
			this.lblAbout.TabIndex = 1;
			this.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// About
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(272, 132);
			this.Controls.Add(this.lblAbout);
			this.Controls.Add(this.btnClose);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "About";
			this.ShowIcon = false;
			this.Text = "About";
			this.Load += new System.EventHandler(this.Form2Load);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label lblAbout;
		private System.Windows.Forms.Button btnClose;
	}
}
