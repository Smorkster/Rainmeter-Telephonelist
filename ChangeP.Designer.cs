namespace Rainmeter
{
    partial class ChangeP
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
        	this.tbName = new System.Windows.Forms.TextBox();
        	this.tbID = new System.Windows.Forms.TextBox();
        	this.tbTel1 = new System.Windows.Forms.TextBox();
        	this.tbTel2 = new System.Windows.Forms.TextBox();
        	this.btnSave = new System.Windows.Forms.Button();
        	this.btnCancel = new System.Windows.Forms.Button();
        	this.labelName = new System.Windows.Forms.Label();
        	this.lblTel2 = new System.Windows.Forms.Label();
        	this.lblTel1 = new System.Windows.Forms.Label();
        	this.labelID = new System.Windows.Forms.Label();
        	this.lblWarning = new System.Windows.Forms.Label();
        	this.labelMail = new System.Windows.Forms.Label();
        	this.tbMail = new System.Windows.Forms.TextBox();
        	this.SuspendLayout();
        	// 
        	// tbName
        	// 
        	this.tbName.Location = new System.Drawing.Point(89, 12);
        	this.tbName.Name = "tbName";
        	this.tbName.Size = new System.Drawing.Size(255, 20);
        	this.tbName.TabIndex = 0;
        	this.tbName.Leave += new System.EventHandler(this.camelCase);
        	// 
        	// tbID
        	// 
        	this.tbID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        	this.tbID.Location = new System.Drawing.Point(89, 38);
        	this.tbID.Name = "tbID";
        	this.tbID.Size = new System.Drawing.Size(255, 20);
        	this.tbID.TabIndex = 1;
        	// 
        	// tbTel1
        	// 
        	this.tbTel1.Location = new System.Drawing.Point(89, 64);
        	this.tbTel1.MaxLength = 15;
        	this.tbTel1.Name = "tbTel1";
        	this.tbTel1.Size = new System.Drawing.Size(255, 20);
        	this.tbTel1.TabIndex = 2;
        	this.tbTel1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telTextChanged);
        	this.tbTel1.Leave += new System.EventHandler(this.groupTel);
        	// 
        	// tbTel2
        	// 
        	this.tbTel2.Location = new System.Drawing.Point(89, 90);
        	this.tbTel2.Name = "tbTel2";
        	this.tbTel2.Size = new System.Drawing.Size(255, 20);
        	this.tbTel2.TabIndex = 3;
        	this.tbTel2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telTextChanged);
        	this.tbTel2.Leave += new System.EventHandler(this.groupTel);
        	// 
        	// btnSave
        	// 
        	this.btnSave.AutoSize = true;
        	this.btnSave.Location = new System.Drawing.Point(364, 12);
        	this.btnSave.Name = "btnSave";
        	this.btnSave.Size = new System.Drawing.Size(80, 23);
        	this.btnSave.TabIndex = 5;
        	this.btnSave.Text = "Save";
        	this.btnSave.UseVisualStyleBackColor = true;
        	this.btnSave.Click += new System.EventHandler(this.sparaPerson_Click);
        	// 
        	// btnCancel
        	// 
        	this.btnCancel.Location = new System.Drawing.Point(364, 41);
        	this.btnCancel.Name = "btnCancel";
        	this.btnCancel.Size = new System.Drawing.Size(80, 23);
        	this.btnCancel.TabIndex = 6;
        	this.btnCancel.Text = "Cancel";
        	this.btnCancel.UseVisualStyleBackColor = true;
        	this.btnCancel.Click += new System.EventHandler(this.savePostCancel_Click);
        	// 
        	// labelName
        	// 
        	this.labelName.AutoSize = true;
        	this.labelName.Location = new System.Drawing.Point(12, 12);
        	this.labelName.Name = "labelName";
        	this.labelName.Size = new System.Drawing.Size(35, 13);
        	this.labelName.TabIndex = 6;
        	this.labelName.Text = "Name";
        	// 
        	// lblTel2
        	// 
        	this.lblTel2.AutoSize = true;
        	this.lblTel2.Location = new System.Drawing.Point(12, 90);
        	this.lblTel2.Name = "lblTel2";
        	this.lblTel2.Size = new System.Drawing.Size(31, 13);
        	this.lblTel2.TabIndex = 7;
        	this.lblTel2.Text = "Tel 2";
        	// 
        	// lblTel1
        	// 
        	this.lblTel1.AutoSize = true;
        	this.lblTel1.Location = new System.Drawing.Point(12, 64);
        	this.lblTel1.Name = "lblTel1";
        	this.lblTel1.Size = new System.Drawing.Size(31, 13);
        	this.lblTel1.TabIndex = 8;
        	this.lblTel1.Text = "Tel 1";
        	// 
        	// labelID
        	// 
        	this.labelID.AutoSize = true;
        	this.labelID.Location = new System.Drawing.Point(12, 38);
        	this.labelID.Name = "labelID";
        	this.labelID.Size = new System.Drawing.Size(16, 13);
        	this.labelID.TabIndex = 9;
        	this.labelID.Text = "Id";
        	// 
        	// lblWarning
        	// 
        	this.lblWarning.Location = new System.Drawing.Point(364, 77);
        	this.lblWarning.Name = "lblWarning";
        	this.lblWarning.Size = new System.Drawing.Size(84, 33);
        	this.lblWarning.TabIndex = 10;
        	// 
        	// labelMail
        	// 
        	this.labelMail.Location = new System.Drawing.Point(12, 116);
        	this.labelMail.Name = "labelMail";
        	this.labelMail.Size = new System.Drawing.Size(48, 18);
        	this.labelMail.TabIndex = 11;
        	this.labelMail.Text = "Mail";
        	// 
        	// tbMail
        	// 
        	this.tbMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
        	this.tbMail.Location = new System.Drawing.Point(89, 116);
        	this.tbMail.Name = "tbMail";
        	this.tbMail.Size = new System.Drawing.Size(255, 20);
        	this.tbMail.TabIndex = 4;
        	this.tbMail.Leave += new System.EventHandler(this.validateMail);
        	// 
        	// ChangeP
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.SystemColors.Control;
        	this.ClientSize = new System.Drawing.Size(460, 142);
        	this.Controls.Add(this.tbMail);
        	this.Controls.Add(this.labelMail);
        	this.Controls.Add(this.lblWarning);
        	this.Controls.Add(this.labelID);
        	this.Controls.Add(this.lblTel1);
        	this.Controls.Add(this.lblTel2);
        	this.Controls.Add(this.labelName);
        	this.Controls.Add(this.btnCancel);
        	this.Controls.Add(this.btnSave);
        	this.Controls.Add(this.tbTel2);
        	this.Controls.Add(this.tbTel1);
        	this.Controls.Add(this.tbID);
        	this.Controls.Add(this.tbName);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        	this.KeyPreview = true;
        	this.MaximizeBox = false;
        	this.MinimizeBox = false;
        	this.Name = "ChangeP";
        	this.ShowIcon = false;
        	this.ShowInTaskbar = false;
        	this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyPressHandler);
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label lblWarning;

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbTel1;
        private System.Windows.Forms.TextBox tbTel2;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label lblTel2;
        private System.Windows.Forms.Label lblTel1;
        private System.Windows.Forms.Label labelID;
    }
}