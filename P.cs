using System;
using System.IO;
using System.Windows.Forms;

namespace Rainmeter
{
	public class FunctionsType3
	{
		/// <summary>
		/// Read content of list and create Rainmeterskin
		/// </summary>
		/// <param name="f1">Mainform, showing all components</param>
		/// <returns>String declaring what list is created</returns>
		public static string createRMSkin(ListView.ListViewItemCollection items)
		{
			string[] meters = new string[3], item = new string[4];
			StreamWriter writerPName = new StreamWriter("Skins\\SETTINGS\\PName.txt", false, System.Text.Encoding.Default),
			writerPTel1 = new StreamWriter("Skins\\SETTINGS\\PTel1.txt", false, System.Text.Encoding.Default),
			writerPTel2 = new StreamWriter("Skins\\SETTINGS\\PTel2.txt", false, System.Text.Encoding.Default);

			foreach (ListViewItem post in items) {
				for (var i = 0; i < 4; i++) {
					item[i] = post.SubItems[i].Text;
				}

				writerPName.WriteLine(item[0]);
				writerPTel1.WriteLine(item[1] + " - " + item[2]);
				writerPTel2.WriteLine(item[3]);
			}

			try {
				writerPName.Close();
			} catch (IOException e) {
				MessageBox.Show("PName could not be written.\r\n" + e.Message);
			}
			try {
				writerPTel1.Close();
			} catch (IOException e) {
				MessageBox.Show("PTel1 could not be written.\r\n" + e.Message);
			}
			try {
				writerPTel2.Close();
			} catch (IOException e) {
				MessageBox.Show("PTel2 could not be written.\r\n" + e.Message);
			}

			return "P Rainmeterlist";
		}
	}
}
