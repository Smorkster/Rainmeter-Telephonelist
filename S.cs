using System;
using System.IO;
using System.Windows.Forms;

namespace Rainmeter
{
	public class FunctionsType2
	{
		/// <summary>
		/// Read content of list and create Rainmeterskin
		/// </summary>
		/// <param name="f1">Mainform, showing all components</param>
		/// <returns>String declaring what list is created</returns>
		public static string createRMSkin(Form1 f1)
		{
			var rowNumber = 0;
			string[] meters = new string[2], item = new string[2];
			StreamWriter writer2Name = new StreamWriter("Skins\\SETTINGS\\2Namn2.txt", false, System.Text.Encoding.Default),
			writer2Tel = new StreamWriter("Skins\\SETTINGS\\2Tel2.txt", false, System.Text.Encoding.Default);

			// Fetch all rows in list2
			foreach (ListViewItem post in f1.list2.Items) {
				for (int i = 0; i < 2; i++) {
					item[i] = post.SubItems[i].Text;
				}

				writer2Name.WriteLine(item[0]);
				writer2Tel.WriteLine(item[1]);
				rowNumber++;
			}

			intTitel("", "int", writer2Name, writer2Tel);

			// Fetch all rows in listI
			foreach (ListViewItem post in f1.listI.Items) {
				for (int i = 0; i < 2; i++) {
					item[i] = post.SubItems[i].Text;
				}

				writer2Name.WriteLine(item[0]);
				writer2Tel.WriteLine(item[1]);
				rowNumber++;
			}

			intTitel("V", "vakt", writer2Name, writer2Tel);

			// Fetch all rows in listJ
			foreach (ListViewItem post in f1.listJ.Items) {
				for (int i = 0; i < 2; i++) {
					item[i] = post.SubItems[i].Text;
				}

				writer2Name.WriteLine(item[0]);
				writer2Tel.WriteLine(item[1]);
				rowNumber++;
			}

			try {
				writer2Name.Close();
			} catch (IOException e) {
				MessageBox.Show("2Name could not be written.\r\n" + e.Message);
			}
			try {
				writer2Tel.Close();
			} catch (IOException e) {
				MessageBox.Show("2Tel could not be written.\r\n" + e.Message);
			}

			return "2 Rainmeterlist";
		}

		static void intTitel(string title, string step, StreamWriter writerBackground2ndName, StreamWriter writerBackground2ndTel)
		{
			string[,] titleText;
			string[] meters = new string[2], temp = new string[2];

			if (step.Equals("vakt"))
				titleText = new string[,] { { " ", " " }, { title, " " } };
			else
				titleText = new string[,] { { title, " " } };

			for (int i = 0; i < titleText.GetLength(0); i++) {
				temp[0] = titleText[i, 0];
				temp[1] = titleText[i, 1];

				writerBackground2ndName.WriteLine(titleText[i, 0]);
				writerBackground2ndTel.WriteLine(titleText[i, 1]);
			}
		}
	}
}
