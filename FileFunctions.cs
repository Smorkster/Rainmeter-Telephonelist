using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Rainmeter
{
	public class FileFunctions
	{
		/// <summary>
		/// Read information from XML-file and print in lists 
		/// </summary>
		/// <param name="f1">Mainform, used to reach the necessary controls</param>
		public static void readFile(Form1 f1)
		{
			var xRead = new XmlTextReader("DONTTOUCH\\Telnr.xml");
			var doc = new XmlDocument();
			XmlNodeList[] xnlStaff = new XmlNodeList[4],
			xnlHD = new XmlNodeList[2],
			xnl2nd = new XmlNodeList[2],
			xnlVxl = new XmlNodeList[2],
			xnlInt = new XmlNodeList[2];

			XmlNodeList name = doc.GetElementsByTagName("name"),
			tel1 = doc.GetElementsByTagName("tel1"),
			id = doc.GetElementsByTagName("id"),
			tel2 = doc.GetElementsByTagName("tel2"),
			mail = doc.GetElementsByTagName("mail"),
			hName = doc.GetElementsByTagName("hname"),
			hTel = doc.GetElementsByTagName("htel"),
			vName = doc.GetElementsByTagName("vname"),
			vTel = doc.GetElementsByTagName("vtel"),
			sName = doc.GetElementsByTagName("sname"),
			sTel = doc.GetElementsByTagName("stel"),
			iName = doc.GetElementsByTagName("iname"),
			iTel = doc.GetElementsByTagName("itel"),
			jName = doc.GetElementsByTagName("jname"),
			jTel = doc.GetElementsByTagName("jtel");

			xRead.WhitespaceHandling = WhitespaceHandling.None;
			doc.Load(xRead);
		    
			var post = new string[5];
			for (int i = 0; i < name.Count; i++) {
				post[0] = name[i].InnerText;
				post[1] = id[i].InnerText;
				post[2] = tel1[i].InnerText;
				post[3] = tel2[i].InnerText;
				post[4] = mail[i].InnerText;
				var listViewItem = new ListViewItem(post);
				f1.listP.Items.Add(listViewItem);
			}

			fillPost(hName, hTel, f1.listH);
			fillPost(vName, vTel, f1.listV);
			fillPost(sName, sTel, f1.list2);
			fillPost(iName, iTel, f1.listI);
			fillPost(jName, jTel, f1.listJ);

			return;
		}

		static void fillPost(XmlNodeList name, XmlNodeList tel, ListView list)
		{
			var post = new string[2];
			for (int i = 0; i < name.Count; i++) {
				post[0] = name[i].InnerText;
				post[1] = tel[i].InnerText;
				var listViewItem = new ListViewItem(post);
				list.Items.Add(listViewItem);
			}
		}

		/// <summary>
		/// Fetch all information in lists and write to XML-file
		/// </summary>
		/// <param name="f">Mainform with all controls</param>
		public static void saveXML(Form1 f)
		{
			var writer = new StreamWriter("DONTTOUCH\\Telnr.xml", false, System.Text.UnicodeEncoding.Unicode);

			try {
				writer.WriteLine("<?xml version=\"1.0\"?>\r\n<telephonenumber>");
	
				fetchPosts(f.list2, writer, new [] { "sname", "stel" });
				fetchPosts(f.listI, writer, new [] { "iname", "itel" });
				fetchPosts(f.listJ, writer, new [] { "jname", "jtel" });
				fetchPosts(f.listH, writer, new [] { "hname", "htel" });
				fetchPosts(f.listV, writer, new [] {
					"vname",
					"vtel"
				});
				fetchPosts(f.listP, writer, new [] {
					"name",
					"id",
					"tel1",
					"tel2",
					"mail"
				});
				writer.WriteLine("</telephonenumber>");
				writer.Close();
				f.tabControl.TabPages[0].Text = "H";
				f.tabControl.TabPages[1].Text = "2";
				f.tabControl.TabPages[2].Text = "P";
			} catch (Exception e) {
				MessageBox.Show("Something went wrong when the XML-file was to be written\nError:\n" + e.Message, "Writingerror", MessageBoxButtons.OK);
			}

			return;
		}

		/// <summary>
		/// Loop through the lists and write to the XML-file
		/// </summary>
		/// <param name="list">Which list is to be read</param>
		/// <param name="writer">StreamWriter for XML-file</param>
		/// <param name="name">Stringarray specifying XML-field</param>
		static void fetchPosts(ListView list, TextWriter writer, string[] name)
		{
			var post = new string[list.Columns.Count];

			foreach (ListViewItem postRow in list.Items) {
				for (int i = 0; i < postRow.SubItems.Count; i++) {
					post[i] = postRow.SubItems[i].Text;
				}

				writer.Write("<contact> ");
				for (int j = 0; j < name.Length; j++)
					writer.Write("<" + name[j] + ">" + post[j] + "</" + name[j] + ">");
				writer.Write(" </contact>\r\n");
				writer.Flush();
			}
		}

		/// <summary>
		/// Check if someone uses the application
		/// Used to prevent changes to be overwritten
		/// </summary>
		/// <returns>Username if it is used, string if not used</returns>
		public static string beingUsed()
		{
			if (File.Exists("DONTTOUCH\\x.lock")) {
				string user;
				var r = new StreamReader("DONTTOUCH\\x.lock");
				user = r.ReadLine();
				return user;
			}
			return "no";
		}

		/// <summary>
		/// Application not in use, create lock-file and write username
		/// </summary>
		public static void Use()
		{
			const string fileName = "DONTTOUCH\\x.lock";

			Directory.CreateDirectory("DONTTOUCH");
			File.Create(fileName).Dispose();
			var writer = new StreamWriter(fileName);

			writer.WriteLine(Environment.UserName);
			writer.Close();
		}
	}
}
