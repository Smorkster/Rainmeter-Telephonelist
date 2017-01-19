using System;
using System.Windows.Forms;
using System.Xml;

namespace Rainmeter
{
	public partial class Help : Form
	{
		public Help()
		{
			InitializeComponent();
			var doc = new XmlTextReader("DONTTOUCH\\Help.xml");
			var pS = new string[2];

			doc.MoveToContent();
			while (doc.Read()) {
				if (doc.NodeType == XmlNodeType.Element) {
					pS[0] = doc.GetAttribute("titel");
					pS[1] = doc.GetAttribute("text");

					lbl_Help.Text += pS[0] + "\n" + pS[1] + "\n\n";
				}
			}
			doc.Close();
		}

		void Btn_CloseClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
