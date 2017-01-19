using System;
using System.IO;
using System.Windows.Forms;

namespace Rainmeter
{
	public class FunctionsType1
	{
		/// <summary>
		/// Read content in ListView and create Rainmetergroup
		/// </summary>
		/// <param name="f1">Mainform containing all controls</param>
		/// <returns>String declaring what list is created</returns>
		public static string createRMSkin(Form1 f1)
		{
			var number = 0;
			string[] meters = new string[2], item = new string[2];
			StreamWriter writerHName = new StreamWriter("Skins\\SETTINGS\\Hname.txt", false, System.Text.Encoding.Default),
			writerHTel = new StreamWriter("Skins\\SETTINGS\\Hname.txt", false, System.Text.Encoding.Default);

			// Fetch all rows in listH
			foreach (ListViewItem post in f1.listH.Items) {
				for (int i = 0; i < 2; i++) {
					item[i] = post.SubItems[i].Text;
				}

				writerHName.WriteLine(item[0]);
				writerHTel.WriteLine(item[1]);
				number++;
			}

			vTitle("Vnumber", writerHName, writerHTel);

			// Fetch all rows in listV
			foreach (ListViewItem itemRow in f1.listV.Items) {
				for (int i = 0; i < 2; i++) {
					item[i] = itemRow.SubItems[i].Text;
				}

				writerHName.WriteLine(item[0]);
				writerHTel.WriteLine(item[1]);
				number++;
			}

			try {
				writerHName.Close();
			} catch (IOException e) {
				MessageBox.Show("HName could not be written.\r\n" + e.Message);
			}
			try {
				writerHTel.Close();
			} catch (IOException e) {
				MessageBox.Show("HTel could not be written.\r\n" + e.Message);
			}
			return "H Rainmeterlist";
		}

		/// <summary>
		/// Create group of vtel numbers
		/// </summary>
		/// <param name="title">Title of the Rainmetergroup</param>
		/// <param name="writerBackgroundHName">Streamwriter for the textfile</param>
		/// <param name="writerBackgroundHTel">Streamwriter for the textfile</param>
		static void vTitle(string title, TextWriter writerBackgroundHName, TextWriter writerBackgroundHTel)
		{
			var v = new string[,] { { "", "" }, { title, " " } };
			string[] meters = new string[2], temp = new string[2];
			for (var i = 0; i < v.GetLength(0); i++) {
				temp[0] = v[i, 0];
				temp[1] = v[i, 1];

				writerBackgroundHName.WriteLine(v[i, 0]);
				writerBackgroundHTel.WriteLine(v[i, 1]);
			}
		}
	}
}
