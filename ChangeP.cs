using System;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Rainmeter
{
	public partial class ChangeP : Form
	{
		string type;
		Form1 f;
		bool newPost = false;

		/// <summary>
		/// Change existing post
		/// </summary>
		/// <param name="f1">Mainform with components</param>
		/// <param name="t">Type of post</param>
		public ChangeP(Form1 f1, string t)
		{
			f = f1;
			startup("", t);
		}

		/// <summary>
		/// Used to create new listitems
		/// Initialize the same form as to change a listitem, but does not load any item
		/// </summary>
		/// <param name="f1">Mainform containing all controls</param>
		/// <param name="n">Used to indicate new post</param>
		/// <param name="t">Type of post</param>
		public ChangeP(Form1 f1, string n, string t)
		{
			f = f1;
			startup(n, t);
		}

		/// <summary>
		/// Initialize form, decide which components to show and how big it should be.
		/// </summary>
		/// <param name="isNewPost">Indicates if it is a new post to be created or an existing to be modified</param>
		/// <param name="t">Type of post to be changed/created</param>
		void startup(string isNewPost, string t)
		{
			InitializeComponent();
			type = t;

			if (type.Equals("hd") || (type.Equals("2nd"))) {
				lblTel2.Visible = false;
				tbTel2.Visible = false;

				labelID.Visible = false;
				tbID.Visible = false;

				labelMail.Visible = false;
				tbMail.Visible = false;

				btnSave.Text = "Save post";
				lblTel1.Text = "Telephone nr";

				tbTel1.Location = new Point(89, 38);
				lblTel1.Location = new Point(12, 38);

				Size = new Size(466, 95);
			}
			if (isNewPost.Equals("new")) {
				newPost = true;
				Text = "New telephonepost";
			} else {
				Text = "Change information";
				loadItem();
			}
		}

		/// <summary>
		/// Read chosen post
		/// </summary>
		void loadItem()
		{
			if (type.Equals("personal")) {
				tbName.Text = f.listP.SelectedItems[0].Text;
				tbID.Text = f.listP.SelectedItems[0].SubItems[1].Text;
				tbTel1.Text = f.listP.SelectedItems[0].SubItems[2].Text;
				tbTel2.Text = f.listP.SelectedItems[0].SubItems[3].Text;
				tbMail.Text = f.listP.SelectedItems[0].SubItems[4].Text;
			} else if (type.Equals("hd")) {
				tbName.Text = f.listH.SelectedItems[0].Text;
				tbTel1.Text = f.listH.SelectedItems[0].SubItems[1].Text;
			} else {
				tbName.Text = f.list2.SelectedItems[0].Text;
				tbTel1.Text = f.list2.SelectedItems[0].SubItems[1].Text;
			}
			tbTel1.Text = tbTel1.Text.Replace(" ", string.Empty);
			groupTel(tbTel1, null);
		}

		/// <summary>
		/// Is called when a post is to be saved
		/// Checked wether the post is to be created or saved
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic EventArgs</param>
		void sparaPerson_Click(object sender, EventArgs e)
		{
			string[] row;
			int i;

			if (newPost) {
				int index;
				if (type.Equals("personal")) {
					row = new [] {
						tbID.Text,
						tbTel1.Text,
						tbTel2.Text,
						tbMail.Text
					};

					f.listP.Items.Add(tbName.Text).SubItems.AddRange(row);
					i = 2;
					index = f.listP.FindItemWithText(tbName.Text, false, 0, true).Index;
					f.listP.Items[index].Selected = true;
					f.listP.Items[index].Focused = true;
					f.listP.EnsureVisible(index);
				} else if (type.Equals("hd")) {
					row = new [] { tbTel1.Text };

					f.listH.Items.Add(tbName.Text).SubItems.AddRange(row);
					i = 0;
					index = f.listH.FindItemWithText(tbName.Text, false, 0, true).Index;
					f.listH.Items[index].Selected = true;
					f.listH.Items[index].Focused = true;
					f.listH.EnsureVisible(index);
				} else {
					row = new [] { tbTel1.Text };

					f.list2.Items.Add(tbName.Text).SubItems.AddRange(row);
					i = 1;
					index = f.list2.FindItemWithText(tbName.Text, false, 0, true).Index;
					f.list2.Items[index].Selected = true;
					f.list2.Items[index].Focused = true;
					f.list2.EnsureVisible(index);
				}
				if (!f.tabControl.TabPages[i].Text.EndsWith("*"))
					f.tabControl.TabPages[i].Text += " *";
			} else {
				if (type.Equals("personal")) {
					f.listP.SelectedItems[0].Text = tbName.Text;
					f.listP.SelectedItems[0].SubItems[1].Text = tbID.Text;
					f.listP.SelectedItems[0].SubItems[2].Text = tbTel1.Text;
					f.listP.SelectedItems[0].SubItems[3].Text = tbTel2.Text;
					f.listP.SelectedItems[0].SubItems[4].Text = tbMail.Text;
					i = 2;
				} else if (type.Equals("hd")) {
					f.listH.SelectedItems[0].Text = tbName.Text;
					f.listH.SelectedItems[0].SubItems[1].Text = tbTel1.Text;
					i = 0;
				} else {
					f.list2.SelectedItems[0].Text = tbName.Text;
					f.list2.SelectedItems[0].SubItems[1].Text = tbTel1.Text;
					i = 1;
				}
				if (!f.tabControl.TabPages[i].Text.EndsWith("*"))
					f.tabControl.TabPages[i].Text += " *";
			}
			Close();
		}

		/// <summary>
		/// Closes form
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic EventArgs</param>
		void savePostCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		/// <summary>
		/// Catches the event of Escape-key being pressed
		/// The form will then be closed
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic KeyEventArgs</param>
		void KeyPressHandler(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				Close();
		}

		/// <summary>
		/// Certifies that only numbers are used in the textboxes
		/// Writes errormessage if other key is used
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic KeyPressEventArgs</param>
		void telTextChanged(object sender, KeyPressEventArgs e)
		{
			string name = ((TextBox)sender).Name;

			lblWarning.Text = "";
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back) {
				lblWarning.Text = "Only numbers are allowed";
				e.Handled = true;
			}
		}

		/// <summary>
		/// Grouping telephonenumber to make it easier to read
		/// Is decided on the lenght of number, and if it is mobile or landline number
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic EventArgs</param>
		void groupTel(object sender, EventArgs e)
		{
			var t = (TextBox)sender;

			if (!t.Text.Equals("")) {
				var tel = new StringBuilder(t.Text);
				string matchText = "", setText = "";
				char a = tel[1];
				int numType = (int)Char.GetNumericValue(a);

				switch (tel.Length) {
					case 5:
						matchText = "(\\d{3})(\\d{2})";
						setText = "$1 $2";
						break;
					case 8:
						t.Text = "08" + t.Text;
						numType = 8;
						goto case 10;
					case 9:
						if (numType == 8) {
							matchText = "(\\d{2})(\\d{3})(\\d{2})(\\d{2})";
							setText = "$1 $2 $3 $4";
						} else if (numType == 2) {
							matchText = "(\\d{3})(\\d{2})(\\d{2})(\\d{2})";
							setText = "$1 $2 $3 $4";
						}
						break;
					case 10:
						switch (numType) {
							case 8:
								matchText = "(\\d{2})(\\d{3})(\\d{3})(\\d{2})";
								setText = "$1 $2 $3 $4";
								break;
							case 2:
								matchText = "(\\d{3})(\\d{3})(\\d{2})(\\d{2})";
								setText = "$1 $2 $3 $4";
								break;
							case 7:
								matchText = "(\\d{4})(\\d{2})(\\d{2})(\\d{2})";
								setText = "$1 $2 $3 $4";
								break;
						}
						break;
					case 11:
						if (numType == 7) {
							matchText = "(\\d{4})(\\d{3})(\\d{2})(\\d{2})";
							setText = "$1 $2 $3 $4";
						}
						break;
				}

				t.Text = Regex.Replace(t.Text, @matchText, setText);
			}
		}

		/// <summary>
		/// Switches first char of names to uppercase
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic EventArgs</param>
		void camelCase(object sender, EventArgs e)
		{
			string name = tbName.Text;
			string temp1 = "", temp2 = "";

			for (int i = 0; i < name.Length; i++) {
				var k = name[i];
				switch (k) {
					case ' ':
						try {
							temp2 = temp2 + temp1[0].ToString().ToUpper() + temp1.Substring(1, temp1.Length - 1) + " ";
							temp1 = null;
						} catch (NullReferenceException er) {
							MessageBox.Show("Error while trying to convert to CamelCase\n" + er);
						}
						break;
					case '-':
						temp2 = temp2 + temp1 + '-';
						temp1 = null;
						break;
					case '(':
						temp2 = temp2 + '(';
						break;
					case ')':
						temp2 = temp2 + temp1[0].ToString().ToUpper() + temp1.Substring(1, temp1.Length - 1) + ")";
						temp1 = null;
						break;
					default:
						temp1 = temp1 + k;
						if (i == name.Length - 1)
							temp2 = temp2 + temp1[0].ToString().ToUpper() + temp1.Substring(1, temp1.Length - 1);
						break;
				}
			}
			tbName.Text = temp2;
		}

		/// <summary>
		/// Verifies that a correct emailadress is written
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic EventArgs</param>
		void validateMail(object sender, EventArgs e)
		{
			string email = this.tbMail.Text;
			var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
			Match match = regex.Match(email);

			if (!match.Success) {
				lblWarning.Text = "Address not valid";
				tbMail.Focus();
			}
		}
	}
}
