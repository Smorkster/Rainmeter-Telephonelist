/*
 * Created by SharpDevelop.
 * User: 6g1w
 * Date: 2013-12-10
 * Time: 12:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Rainmeter
{
	partial class WhatToSave
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
			this.chbRmLists = new System.Windows.Forms.CheckBox();
			this.chbCLists = new System.Windows.Forms.CheckBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// chbRmLists
			// 
			this.chbRmLists.AutoSize = true;
			this.chbRmLists.Location = new System.Drawing.Point(12, 12);
			this.chbRmLists.Name = "chbRmLists";
			this.chbRmLists.Size = new System.Drawing.Size(95, 17);
			this.chbRmLists.TabIndex = 0;
			this.chbRmLists.Text = "Rainmeterlistor";
			this.chbRmLists.UseVisualStyleBackColor = true;
			// 
			// chbCLists
			// 
			this.chbCLists.AutoSize = true;
			this.chbCLists.Location = new System.Drawing.Point(12, 35);
			this.chbCLists.Name = "chbCLists";
			this.chbCLists.Size = new System.Drawing.Size(84, 17);
			this.chbCLists.TabIndex = 1;
			this.chbCLists.Text = "Kontaktlistor";
			this.chbCLists.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSave.Location = new System.Drawing.Point(175, 31);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.Button1_Click);
			// 
			// WhatToSave
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(262, 67);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.chbCLists);
			this.Controls.Add(this.chbRmLists);
			this.Name = "WhatToSave";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "What do you want to save?";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.CheckBox chbCLists;
		private System.Windows.Forms.CheckBox chbRmLists;
	}
}
