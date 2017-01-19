namespace Rainmeter
{
    partial class Form1
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
        	this.btnClose = new System.Windows.Forms.Button();
        	this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        	this.mmenuSave = new System.Windows.Forms.ToolStripMenuItem();
        	this.mmenuChangeRemove = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuiChange = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuiRemove = new System.Windows.Forms.ToolStripMenuItem();
        	this.mmenuNew = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuiNewH = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuNew2 = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuiNewP = new System.Windows.Forms.ToolStripMenuItem();
        	this.mmenuHelp = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuIHelp = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuIAbout = new System.Windows.Forms.ToolStripMenuItem();
        	this.tabPage3 = new System.Windows.Forms.TabPage();
        	this.listP = new System.Windows.Forms.ListView();
        	this.colPName = new System.Windows.Forms.ColumnHeader();
        	this.colPId = new System.Windows.Forms.ColumnHeader();
        	this.colPTel1 = new System.Windows.Forms.ColumnHeader();
        	this.colPTel2 = new System.Windows.Forms.ColumnHeader();
        	this.colPMail = new System.Windows.Forms.ColumnHeader();
        	this.tabPage2 = new System.Windows.Forms.TabPage();
        	this.listJ = new System.Windows.Forms.ListView();
        	this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
        	this.listI = new System.Windows.Forms.ListView();
        	this.iName = new System.Windows.Forms.ColumnHeader();
        	this.iTel = new System.Windows.Forms.ColumnHeader();
        	this.list2 = new System.Windows.Forms.ListView();
        	this.col2 = new System.Windows.Forms.ColumnHeader();
        	this.col22 = new System.Windows.Forms.ColumnHeader();
        	this.tabPage1 = new System.Windows.Forms.TabPage();
        	this.listV = new System.Windows.Forms.ListView();
        	this.vName = new System.Windows.Forms.ColumnHeader();
        	this.vTel = new System.Windows.Forms.ColumnHeader();
        	this.listH = new System.Windows.Forms.ListView();
        	this.colDesc = new System.Windows.Forms.ColumnHeader();
        	this.colTel = new System.Windows.Forms.ColumnHeader();
        	this.tabControl = new System.Windows.Forms.TabControl();
        	this.menuStrip1.SuspendLayout();
        	this.tabPage3.SuspendLayout();
        	this.tabPage2.SuspendLayout();
        	this.tabPage1.SuspendLayout();
        	this.tabControl.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// btnClose
        	// 
        	this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.btnClose.Location = new System.Drawing.Point(580, 407);
        	this.btnClose.Name = "btnClose";
        	this.btnClose.Size = new System.Drawing.Size(75, 23);
        	this.btnClose.TabIndex = 3;
        	this.btnClose.Text = "Close";
        	this.btnClose.UseVisualStyleBackColor = true;
        	this.btnClose.Click += new System.EventHandler(this.close_Click);
        	// 
        	// menuStrip1
        	// 
        	this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mmenuSave,
			this.mmenuChangeRemove,
			this.mmenuNew,
			this.mmenuHelp});
        	this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        	this.menuStrip1.Name = "menuStrip1";
        	this.menuStrip1.Size = new System.Drawing.Size(671, 24);
        	this.menuStrip1.TabIndex = 1;
        	this.menuStrip1.TabStop = true;
        	this.menuStrip1.Text = "menuStrip1";
        	// 
        	// mmenuSave
        	// 
        	this.mmenuSave.Name = "mmenuSave";
        	this.mmenuSave.Size = new System.Drawing.Size(90, 20);
        	this.mmenuSave.Text = "Save changes";
        	this.mmenuSave.Click += new System.EventHandler(this.SaveChanges);
        	// 
        	// mmenuChangeRemove
        	// 
        	this.mmenuChangeRemove.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuiChange,
			this.menuiRemove});
        	this.mmenuChangeRemove.Name = "mmenuChangeRemove";
        	this.mmenuChangeRemove.Size = new System.Drawing.Size(104, 20);
        	this.mmenuChangeRemove.Text = "Change / Delete";
        	// 
        	// menuiChange
        	// 
        	this.menuiChange.Name = "menuiChange";
        	this.menuiChange.Size = new System.Drawing.Size(152, 22);
        	this.menuiChange.Text = "Change";
        	this.menuiChange.Click += new System.EventHandler(this.menuChangeClick);
        	// 
        	// menuiRemove
        	// 
        	this.menuiRemove.Name = "menuiRemove";
        	this.menuiRemove.Size = new System.Drawing.Size(152, 22);
        	this.menuiRemove.Text = "Delete";
        	this.menuiRemove.Click += new System.EventHandler(this.menuRemoveClick);
        	// 
        	// mmenuNew
        	// 
        	this.mmenuNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuiNewH,
			this.menuNew2,
			this.menuiNewP});
        	this.mmenuNew.Name = "mmenuNew";
        	this.mmenuNew.Size = new System.Drawing.Size(43, 20);
        	this.mmenuNew.Text = "New";
        	// 
        	// menuiNewH
        	// 
        	this.menuiNewH.Name = "menuiNewH";
        	this.menuiNewH.Size = new System.Drawing.Size(152, 22);
        	this.menuiNewH.Text = "H";
        	this.menuiNewH.Click += new System.EventHandler(this.menuNewH_Click);
        	// 
        	// menuNew2
        	// 
        	this.menuNew2.Name = "menuNew2";
        	this.menuNew2.Size = new System.Drawing.Size(152, 22);
        	this.menuNew2.Text = "2";
        	this.menuNew2.Click += new System.EventHandler(this.menuNew2_Click);
        	// 
        	// menuiNewP
        	// 
        	this.menuiNewP.Name = "menuiNewP";
        	this.menuiNewP.Size = new System.Drawing.Size(152, 22);
        	this.menuiNewP.Text = "P";
        	this.menuiNewP.Click += new System.EventHandler(this.menuNewP_Click);
        	// 
        	// mmenuHelp
        	// 
        	this.mmenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuIHelp,
			this.menuIAbout});
        	this.mmenuHelp.Name = "mmenuHelp";
        	this.mmenuHelp.Size = new System.Drawing.Size(44, 20);
        	this.mmenuHelp.Text = "Help";
        	// 
        	// menuIHelp
        	// 
        	this.menuIHelp.Name = "menuIHelp";
        	this.menuIHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
        	this.menuIHelp.Size = new System.Drawing.Size(152, 22);
        	this.menuIHelp.Text = "Help";
        	this.menuIHelp.Click += new System.EventHandler(this.menuHelpClick);
        	// 
        	// menuIAbout
        	// 
        	this.menuIAbout.Name = "menuIAbout";
        	this.menuIAbout.Size = new System.Drawing.Size(152, 22);
        	this.menuIAbout.Text = "About";
        	this.menuIAbout.Click += new System.EventHandler(this.menuAboutClick);
        	// 
        	// tabPage3
        	// 
        	this.tabPage3.Controls.Add(this.listP);
        	this.tabPage3.Location = new System.Drawing.Point(4, 22);
        	this.tabPage3.Name = "tabPage3";
        	this.tabPage3.Size = new System.Drawing.Size(635, 344);
        	this.tabPage3.TabIndex = 2;
        	this.tabPage3.Text = "P";
        	this.tabPage3.UseVisualStyleBackColor = true;
        	// 
        	// listP
        	// 
        	this.listP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.listP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.colPName,
			this.colPId,
			this.colPTel1,
			this.colPTel2,
			this.colPMail});
        	this.listP.FullRowSelect = true;
        	this.listP.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
        	this.listP.Location = new System.Drawing.Point(0, 1);
        	this.listP.MultiSelect = false;
        	this.listP.Name = "listP";
        	this.listP.Size = new System.Drawing.Size(633, 343);
        	this.listP.Sorting = System.Windows.Forms.SortOrder.Ascending;
        	this.listP.TabIndex = 1;
        	this.listP.TabStop = false;
        	this.listP.UseCompatibleStateImageBehavior = false;
        	this.listP.View = System.Windows.Forms.View.Details;
        	this.listP.DoubleClick += new System.EventHandler(this.doubleClickP);
        	// 
        	// colPName
        	// 
        	this.colPName.Text = "Name";
        	this.colPName.Width = 157;
        	// 
        	// colPId
        	// 
        	this.colPId.Text = "Id";
        	// 
        	// colPTel1
        	// 
        	this.colPTel1.Text = "Tel 1";
        	this.colPTel1.Width = 73;
        	// 
        	// colPTel2
        	// 
        	this.colPTel2.Text = "Tel 2";
        	this.colPTel2.Width = 101;
        	// 
        	// colPMail
        	// 
        	this.colPMail.Text = "Mail";
        	this.colPMail.Width = 221;
        	// 
        	// tabPage2
        	// 
        	this.tabPage2.Controls.Add(this.listJ);
        	this.tabPage2.Controls.Add(this.listI);
        	this.tabPage2.Controls.Add(this.list2);
        	this.tabPage2.Location = new System.Drawing.Point(4, 22);
        	this.tabPage2.Name = "tabPage2";
        	this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
        	this.tabPage2.Size = new System.Drawing.Size(635, 344);
        	this.tabPage2.TabIndex = 1;
        	this.tabPage2.Text = "2";
        	this.tabPage2.UseVisualStyleBackColor = true;
        	// 
        	// listJ
        	// 
        	this.listJ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.listJ.AutoArrange = false;
        	this.listJ.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeader1,
			this.columnHeader2});
        	this.listJ.FullRowSelect = true;
        	this.listJ.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
        	this.listJ.ImeMode = System.Windows.Forms.ImeMode.On;
        	this.listJ.Location = new System.Drawing.Point(319, 175);
        	this.listJ.MultiSelect = false;
        	this.listJ.Name = "listJ";
        	this.listJ.Size = new System.Drawing.Size(314, 169);
        	this.listJ.Sorting = System.Windows.Forms.SortOrder.Ascending;
        	this.listJ.TabIndex = 4;
        	this.listJ.TabStop = false;
        	this.listJ.UseCompatibleStateImageBehavior = false;
        	this.listJ.View = System.Windows.Forms.View.Details;
        	this.listJ.Enter += new System.EventHandler(this.noChange);
        	this.listJ.Leave += new System.EventHandler(this.yesChange);
        	// 
        	// columnHeader1
        	// 
        	this.columnHeader1.Text = "I";
        	this.columnHeader1.Width = 160;
        	// 
        	// columnHeader2
        	// 
        	this.columnHeader2.Text = "I telephone";
        	this.columnHeader2.Width = 115;
        	// 
        	// listI
        	// 
        	this.listI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.listI.AutoArrange = false;
        	this.listI.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.iName,
			this.iTel});
        	this.listI.FullRowSelect = true;
        	this.listI.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
        	this.listI.ImeMode = System.Windows.Forms.ImeMode.On;
        	this.listI.Location = new System.Drawing.Point(319, 1);
        	this.listI.MultiSelect = false;
        	this.listI.Name = "listI";
        	this.listI.Size = new System.Drawing.Size(314, 171);
        	this.listI.Sorting = System.Windows.Forms.SortOrder.Ascending;
        	this.listI.TabIndex = 3;
        	this.listI.TabStop = false;
        	this.listI.UseCompatibleStateImageBehavior = false;
        	this.listI.View = System.Windows.Forms.View.Details;
        	this.listI.Enter += new System.EventHandler(this.noChange);
        	this.listI.Leave += new System.EventHandler(this.yesChange);
        	// 
        	// iName
        	// 
        	this.iName.Text = "I";
        	this.iName.Width = 160;
        	// 
        	// iTel
        	// 
        	this.iTel.Text = "I telephone";
        	this.iTel.Width = 115;
        	// 
        	// list2
        	// 
        	this.list2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.list2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.col2,
			this.col22});
        	this.list2.FullRowSelect = true;
        	this.list2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
        	this.list2.ImeMode = System.Windows.Forms.ImeMode.On;
        	this.list2.Location = new System.Drawing.Point(0, 1);
        	this.list2.MultiSelect = false;
        	this.list2.Name = "list2";
        	this.list2.Size = new System.Drawing.Size(316, 343);
        	this.list2.Sorting = System.Windows.Forms.SortOrder.Ascending;
        	this.list2.TabIndex = 2;
        	this.list2.TabStop = false;
        	this.list2.UseCompatibleStateImageBehavior = false;
        	this.list2.View = System.Windows.Forms.View.Details;
        	this.list2.DoubleClick += new System.EventHandler(this.doubleClick2nd);
        	// 
        	// col2
        	// 
        	this.col2.Text = "2";
        	this.col2.Width = 160;
        	// 
        	// col22
        	// 
        	this.col22.Text = "Telephone";
        	this.col22.Width = 115;
        	// 
        	// tabPage1
        	// 
        	this.tabPage1.Controls.Add(this.listV);
        	this.tabPage1.Controls.Add(this.listH);
        	this.tabPage1.Location = new System.Drawing.Point(4, 22);
        	this.tabPage1.Name = "tabPage1";
        	this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
        	this.tabPage1.Size = new System.Drawing.Size(635, 344);
        	this.tabPage1.TabIndex = 0;
        	this.tabPage1.Text = "H";
        	this.tabPage1.UseVisualStyleBackColor = true;
        	// 
        	// listV
        	// 
        	this.listV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.listV.AutoArrange = false;
        	this.listV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.vName,
			this.vTel});
        	this.listV.FullRowSelect = true;
        	this.listV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
        	this.listV.Location = new System.Drawing.Point(319, 1);
        	this.listV.MultiSelect = false;
        	this.listV.Name = "listV";
        	this.listV.Size = new System.Drawing.Size(314, 341);
        	this.listV.Sorting = System.Windows.Forms.SortOrder.Ascending;
        	this.listV.TabIndex = 1;
        	this.listV.TabStop = false;
        	this.listV.UseCompatibleStateImageBehavior = false;
        	this.listV.View = System.Windows.Forms.View.Details;
        	this.listV.Enter += new System.EventHandler(this.noChange);
        	this.listV.Leave += new System.EventHandler(this.yesChange);
        	// 
        	// vName
        	// 
        	this.vName.Text = "V";
        	this.vName.Width = 160;
        	// 
        	// vTel
        	// 
        	this.vTel.Text = "V telephone";
        	this.vTel.Width = 115;
        	// 
        	// listH
        	// 
        	this.listH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.listH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.colDesc,
			this.colTel});
        	this.listH.FullRowSelect = true;
        	this.listH.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
        	this.listH.Location = new System.Drawing.Point(0, 1);
        	this.listH.MultiSelect = false;
        	this.listH.Name = "listH";
        	this.listH.Size = new System.Drawing.Size(316, 341);
        	this.listH.Sorting = System.Windows.Forms.SortOrder.Ascending;
        	this.listH.TabIndex = 0;
        	this.listH.TabStop = false;
        	this.listH.UseCompatibleStateImageBehavior = false;
        	this.listH.View = System.Windows.Forms.View.Details;
        	this.listH.DoubleClick += new System.EventHandler(this.doubleClickHD);
        	// 
        	// colDesc
        	// 
        	this.colDesc.Text = "H";
        	this.colDesc.Width = 160;
        	// 
        	// colTel
        	// 
        	this.colTel.Text = "Telephone";
        	this.colTel.Width = 115;
        	// 
        	// tabControl
        	// 
        	this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.tabControl.Controls.Add(this.tabPage1);
        	this.tabControl.Controls.Add(this.tabPage2);
        	this.tabControl.Controls.Add(this.tabPage3);
        	this.tabControl.Location = new System.Drawing.Point(12, 27);
        	this.tabControl.Name = "tabControl";
        	this.tabControl.SelectedIndex = 0;
        	this.tabControl.Size = new System.Drawing.Size(643, 370);
        	this.tabControl.TabIndex = 4;
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(671, 442);
        	this.Controls.Add(this.tabControl);
        	this.Controls.Add(this.btnClose);
        	this.Controls.Add(this.menuStrip1);
        	this.KeyPreview = true;
        	this.MaximizeBox = false;
        	this.MinimizeBox = false;
        	this.MinimumSize = new System.Drawing.Size(683, 474);
        	this.Name = "Form1";
        	this.ShowIcon = false;
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        	this.menuStrip1.ResumeLayout(false);
        	this.menuStrip1.PerformLayout();
        	this.tabPage3.ResumeLayout(false);
        	this.tabPage2.ResumeLayout(false);
        	this.tabPage1.ResumeLayout(false);
        	this.tabControl.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ListView listJ;
        private System.Windows.Forms.ColumnHeader iTel;
        private System.Windows.Forms.ColumnHeader iName;
        public System.Windows.Forms.ListView listI;
        private System.Windows.Forms.ColumnHeader vTel;
        private System.Windows.Forms.ColumnHeader vName;
        public System.Windows.Forms.ListView listV;
        private System.Windows.Forms.ColumnHeader colPMail;
        private System.Windows.Forms.ToolStripMenuItem menuIAbout;
        private System.Windows.Forms.ToolStripMenuItem menuIHelp;
        private System.Windows.Forms.ToolStripMenuItem mmenuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuiNewP;
        private System.Windows.Forms.ToolStripMenuItem menuNew2;
        private System.Windows.Forms.ToolStripMenuItem menuiNewH;
        private System.Windows.Forms.ToolStripMenuItem mmenuNew;
        private System.Windows.Forms.ToolStripMenuItem menuiRemove;
        private System.Windows.Forms.ToolStripMenuItem menuiChange;
        private System.Windows.Forms.ToolStripMenuItem mmenuChangeRemove;
        private System.Windows.Forms.ToolStripMenuItem mmenuSave;
        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.ListView listH;
        private System.Windows.Forms.ColumnHeader colDesc;
        private System.Windows.Forms.ColumnHeader colTel;
        public System.Windows.Forms.TabControl tabControl;
        public System.Windows.Forms.ListView list2;
        private System.Windows.Forms.ColumnHeader col2;
        private System.Windows.Forms.ColumnHeader col22;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.ListView listP;
        private System.Windows.Forms.ColumnHeader colPName;
        private System.Windows.Forms.ColumnHeader colPId;
        private System.Windows.Forms.ColumnHeader colPTel1;
        private System.Windows.Forms.ColumnHeader colPTel2;
    }
}