using System;
using System.Windows.Forms;

namespace Rainmeter
{
	public partial class WhatToSave : Form
	{
		bool[] temp = new bool[2];

		/// <summary>
		/// Checkboxes to determine which files to be updated
		/// </summary>
		/// <param name="save">Booleanarray for what files to save</param>
		public WhatToSave(ref bool[] save)
		{
			InitializeComponent();
			temp = save;
		}

		/// <summary>
		/// Set the bool for file to save and close form
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic EventArgs</param>
		void Button1_Click(object sender, EventArgs e)
		{
			if (chbRmLists.Checked)
				temp[0] = true;
			temp[1] |= chbCLists.Checked;
			
			Close();
		}
	}
}
