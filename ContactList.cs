using System;
using System.IO;
using System.Windows.Forms;

namespace Rainmeter
{
	public class ContactList
	{
		public static void createContactlist(ListView lista, bool append)
		{
			var contact = new Telnr();
			char[] difChar = { ' ' };
			//Firstname 0, Lastname 1, Id 2, Telephone1 3, Telephone2 4, Mail 5
			var person = new string[6];
			string[] splitName;
			string[] gstyle = new string[35], msstyle = new string[88], astyle = new string[4];
			StreamWriter writegstyle = new StreamWriter("Contacts (Google-style).csv", append),
			writemsstyle = new StreamWriter("Contacts (MS-style).csv", append),
			writeastyle = new StreamWriter("Contacts (Apple-style).vcf", append);

			if (!append) {
				writegstyle.WriteLine("Name,Given Name,Additional Name,Family Name,Yomi Name,Given Name Yomi,Additional Name Yomi,Family Name Yomi,Name Prefix,Name Suffix,Initials,Nickname,Short Name,Maiden Name,Birthday,Gender,Location,Billing Information,Directory Server,Mileage,Occupation,Hobby,Sensitivity,Priority,Subject,Notes,Group Membership,E-mail 1 - Type,E-mail 1 - Value,E-mail 2 - Type,E-mail 2 - Value,E-mail 3 - Type,E-mail 3 - Value,Phone 1 - Type,Phone 1 - Value");
				writemsstyle.WriteLine("First Name,Middle Name,Last Name,Title,Suffix,Initials,Web Page,Gender,Birthday,Anniversary,Location,Language,Internet Free Busy,Notes,E-mail Address,E-mail 2 Address,E-mail 3 Address,Primary Phone,Home Phone,Home Phone 2,Mobile Phone,Pager,Home Fax,Home Address,Home Street,Home Street 2,Home Street 3,Home Address PO Box,Home City,Home State,Home Postal Code,Home Country,Spouse,Children,Manager's Name,Assistant's Name,Referred By,Company Main Phone,Business Phone,Business Phone 2,Business Fax,Assistant's Phone,Company,Job Title,Department,Office Location,Organizational ID Number,Profession,Account,Business Address,Business Street,Business Street 2,Business Street 3,Business Address PO Box,Business City,Business State,Business Postal Code,Business Country,Other Phone,Other Fax,Other Address,Other Street,Other Street 2,Other Street 3,Other Address PO Box,Other City,Other State,Other Postal Code,Other Country,Callback,Car Phone,ISDN,Radio Phone,TTY/TDD Phone,Telex,User 1,User 2,User 3,User 4,Keywords,Mileage,Hobby,Billing Information,Directory Server,Sensitivity,Priority,Private,Categories");
			}
			foreach (ListViewItem post in lista.Items) {
				if (post.SubItems.Count == 5) {
					splitName = post.SubItems[0].Text.Split(difChar);
					for (int q = 0; q < splitName.Length; q++) {
						if (q == 0)
							contact.Name = splitName[0];
						else
							contact.SurName = contact.SurName + splitName[q];
					}
					contact.Tel2 = post.SubItems[3].Text;
					contact.EMail = post.SubItems[4].Text;
					splitName = null;

				} else {
					contact.Name = post.SubItems[0].Text;
					contact.Tel2 = post.SubItems[1].Text;
				}
				//VCard
				writeastyle.WriteLine("BEGIN:VCARD\nVERSION:3.0\nFN:" + contact.Name + " " + contact.SurName + "\nN:" + contact.SurName + ";" + contact.Name + ";;;\nEMAIL;TYPE=INTERNET;TYPE=WORK:" + contact.EMail + "\nTEL;TYPE=CELL:" + contact.Tel2 + "\nEND:VCARD");
				writeastyle.Flush();
				//Google Style
				writegstyle.WriteLine(contact.Name + " " + contact.SurName + "," + contact.Name + ",," + contact.SurName + ",,,,,,,,,,,,,,,,,,,,,,,* SLLIT Servicedesk,* Work," + contact.EMail + ",,,,,Mobile," + contact.Tel2);
				writegstyle.Flush();
				//MS Style
				writemsstyle.WriteLine(contact.Name + ",," + contact.SurName + ",,,,,,,,,,,," + contact.EMail + ",,,,,," + contact.Tel2 + ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,Normal,,SLLIT Servicedesk,");
				writemsstyle.Flush();

				splitName = null;
				contact = new Telnr();
			}
			writegstyle.Close();
			writemsstyle.Close();
			writeastyle.Close();
		}
	}
}
