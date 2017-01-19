using System;
using System.Windows.Forms;

namespace Rainmeter
{
	public partial class About : Form
	{
		public About()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Show text about the application
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic EventArgs</param>
		void Form2Load(object sender, EventArgs e)
		{
			lblAbout.Text = "Tool to update telephonelists for Rainmeter.";
		}

		/// <summary>
		/// Close About-form
		/// </summary>
		/// <param name="sender">Generic object</param>
		/// <param name="e">Generic EventArgs</param>
		void Btn_CloseClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
