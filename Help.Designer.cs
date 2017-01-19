/*
 * Created by SharpDevelop.
 * User: 6g1w
 * Date: 2012-09-19
 * Time: 11:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Rainmeter
{
	partial class Help
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
			this.lbl_Help = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_Help
			// 
			this.lbl_Help.Location = new System.Drawing.Point(12, 9);
			this.lbl_Help.Name = "lbl_Help";
			this.lbl_Help.Size = new System.Drawing.Size(361, 291);
			this.lbl_Help.TabIndex = 0;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(298, 313);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.Btn_CloseClick);
			// 
			// Help
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(385, 348);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lbl_Help);
			this.Name = "Help";
			this.Text = "Help";
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lbl_Help;
	}
}
