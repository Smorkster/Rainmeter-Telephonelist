using System;
using System.IO;
using System.Windows.Forms;

namespace Rainmeter
{
	public partial class Form1 : Form
	{
		static void Main()
		{
			var user = FileFunctions.beingUsed();

			if (user.Equals("no")) {
				FileFunctions.Use();
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Form1());
			} else {
				MessageBox.Show("Program is in use by " + user + ". It will now close.", "", MessageBoxButtons.OK);
				Application.Exit();
			}
		}

		/// <summary>
		/// Start application and initialize reading of XML-file
		/// If file does not exist on given adress, the lists are loaded empty
		/// </summary>
		public Form1()
		{
			InitializeComponent();

			if (File.Exists("DONTTOUCH\\Telnr.xml"))
				FileFunctions.readFile(this);
			else
				MessageBox.Show("File 'Telnr.xml' is missing.\nLists will be empty.");
		}

		/// <summary>
		/// Application is closed
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic EventArgs</param>
		void close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		/// <summary>
		/// Create new post
		/// Calls ChangeStaff with 'new' to indicate that a new post is to be created
		/// </summary>
		/// <param name="type">Type of post</param>
		void newPost(string type)
		{
			var p = new ChangeP(this, "new", type);
			p.ShowDialog();
		}

		/// <summary>
		/// Save changes made in the lists
		/// Calls functions to create Rainmeterskin for each telefphonelist and saves XML-file
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic EventArgs</param>
		void SaveChanges(object sender, EventArgs e)
		{
			var save = new bool[2];
			string log = "Files saved:" + "\r\n";
        	
			var w = new WhatToSave(ref save);
			w.ShowDialog();
        	
			if (save[0]) {
				log = log + FunctionsType1.createRMSkin(this) + "\r\n";
				log = log + FunctionsType2.createRMSkin(this) + "\r\n";
				log = log + FunctionsType3.createRMSkin(listP.Items) + "\r\n";
			} else if (save[1]) {
				ContactList.createContactlist(listP, false);
				ContactList.createContactlist(list2, true);
				ContactList.createContactlist(listI, true);
				log = log + "Contactlists" + "\r\n";
			}
			FileFunctions.saveXML(this);
			log = log + "XML-file";
			MessageBox.Show(log);
		}

		/// <summary>
		/// Change post
		/// Check which tab has focus, then call form ChangeStaff to change post
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic EventArgs</param>
		void menuChangeClick(object sender, EventArgs e)
		{
			string typeToChange = "";
			bool change = true;

			if (tabControl.SelectedIndex == 0) {
				if (listH.SelectedItems.Count == 0)
					change = false;
				else
					typeToChange = "hd";
			} else if (tabControl.SelectedIndex == 1) {
				if (list2.SelectedItems.Count == 0)
					change = false;
				else
					typeToChange = "2nd";
			} else {
				if (listP.SelectedItems.Count == 0)
					change = false;
				else
					typeToChange = "personal";
			}

			if (change) {
				var p = new ChangeP(this, typeToChange);
				p.ShowDialog();
			}
		}

		/// <summary>
		/// Menuitem is pressed
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic EventArgs</param>
		void menuNewH_Click(object sender, EventArgs e)
		{
			newPost("hd");
			tabControl.SelectedIndex = 0;
		}

		/// <summary>
		/// Menuitem is pressed
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic EventArgs</param>
		void menuNew2_Click(object sender, EventArgs e)
		{
			newPost("2nd");
			tabControl.SelectedIndex = 1;
		}

		/// <summary>
		/// Menuitem is pressed
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic EventArgs</param>
		void menuNewP_Click(object sender, EventArgs e)
		{
			newPost("personal");
			tabControl.SelectedIndex = 2;
		}

		/// <summary>
		/// Menuitem is pressed
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic EventArgs</param>
		void menuAboutClick(object sender, EventArgs e)
		{
			var p = new About();
			p.ShowDialog();
		}

		/// <summary>
		/// Menuitem is pressed
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic EventArgs</param>
		void menuHelpClick(object sender, EventArgs e)
		{
			var p = new Help();
			p.Show();
		}

		/// <summary>
		/// Remove marked post
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic EventArgs</param>
		void menuRemoveClick(object sender, EventArgs e)
		{
			switch (tabControl.SelectedIndex) {
				case 0:
					if (removeQuestion(listH.SelectedItems[0].Text, "Helpdesk") == DialogResult.Yes) {
						listH.Items.Remove(listH.SelectedItems[0]);
					}
					break;
				case 1:
					if (removeQuestion(list2.SelectedItems[0].Text, "2nd line") == DialogResult.Yes) {
						list2.Items.Remove(list2.SelectedItems[0]);
					}
					break;
				case 2:
					if (removeQuestion(listP.SelectedItems[0].Text, "Personal") == DialogResult.Yes) {
						listP.Items.Remove(listP.SelectedItems[0]);
					}
					break;
			}
			if (!tabControl.TabPages[tabControl.SelectedIndex].Text.EndsWith("*"))
				tabControl.TabPages[tabControl.SelectedIndex].Text += " *";
		}

		/// <summary>
		/// Check if OK to remove post
		/// </summary>
		/// <param name="name">Name in post</param>
		/// <param name="desk">Which list is the post located in</param>
		/// <returns>True or False if user wants to remove post</returns>
		DialogResult removeQuestion(string name, string desk)
		{
			return MessageBox.Show("Are your sure about removing " + name + "?", "Removal of " + desk + " post", MessageBoxButtons.YesNo);
		}

		/// <summary>
		/// Is called when application is being closed
		/// Check if changes have been made then ask if changes is to be saved
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic FormClosingEventArgs</param>
		void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult answer;

			if (tabControl.TabPages[0].Text.EndsWith("*") || tabControl.TabPages[1].Text.EndsWith("*") || tabControl.TabPages[2].Text.EndsWith("*")) {
				answer = MessageBox.Show("Lists have changed, but is not saved.\nSave lists before closing?", "Unsaved changes", MessageBoxButtons.YesNoCancel);
				if (answer == DialogResult.Yes) {
					SaveChanges(sender, e);
				} else if (answer == DialogResult.Cancel) {
					e.Cancel = true;
				}
			}
			File.Delete("DONTTOUCH\\x.lock");
		}

		/// <summary>
		/// Catch doubleclick in list
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic EventArgs</param>
		void doubleClickHD(object sender, EventArgs e)
		{
			var p = new ChangeP(this, "hd");
			p.ShowDialog();
		}

		/// <summary>
		/// Catch doubleclick in list
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic EventArgs</param>
		void doubleClick2nd(object sender, EventArgs e)
		{
			var p = new ChangeP(this, "2nd");
			p.ShowDialog();
		}

		/// <summary>
		/// Catch doubleclick in list
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic EventArgs</param>
		void doubleClickP(object sender, EventArgs e)
		{
			var p = new ChangeP(this, "personal");
			p.ShowDialog();
		}

		/// <summary>
		/// Block ability to change in the lists telexchange, janitor and internal by disabling
		/// menuitem changeRemove if the lists have focus
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic EventArgs</param>
		void noChange(object sender, EventArgs e)
		{
			mmenuChangeRemove.Enabled = false;
		}

		/// <summary>
		/// Enable menuitem changeRemove if the lists telexchange, janitor and internal loose focus
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic EventArgs</param>
		void yesChange(object sender, EventArgs e)
		{
			mmenuChangeRemove.Enabled = true;
		}
	}
}
