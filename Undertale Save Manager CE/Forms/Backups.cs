using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace Undertale_Save_Manager_CE
{
    public partial class frm_backups : Form
    {
        public frm_backups()
        {
            InitializeComponent();//Load the designer.cs
            this.MaximumSize = this.Size; this.MinimumSize = this.Size;
            foreach (ColumnHeader col in lv_backups.Columns)
            {
                col.Width = (lv_backups.Width / lv_backups.Columns.Count);//Set the columns width to fit in the listview
            }
            //Disable the backup controls
            lv_backups.MultiSelect = false;
            ms_backup_restore.Enabled = false;
            ms_backup_delete.Enabled = false;
        }

        public void refresh() //Refresh the list of backup items
        {
            lv_backups.Items.Clear();
            XDocument doc = XDocument.Load(USM.FILE_BACKUPSXML); //Load the backups.xml file
            List<XElement> backups = doc.Element("Backups").Elements().ToList(); //Get all the backups
            foreach (XElement backup in backups)//Add the backups to the list
            {
                string name, date, time;
                name = backup.Element("Name").Value;
                date = backup.Element("Date").Value;
                time = backup.Element("Time").Value;
                string[] args = new string[] { name, date, time };
                ListViewItem item = lv_backups.Items.Add(new ListViewItem(args));
                item.Tag = backup.Element("Dname").Value;
            }
        }

        private void Backups_Load(object sender, EventArgs e)//When the form has loaded
        {
            refresh(); //Get the backups
        }

        private void ms_backup_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lv_backups_SelectedIndexChanged(object sender, EventArgs e) //If index has changed
        {
            if(lv_backups.SelectedItems.Count > 0) //And an item is selected
            {
                ms_backup_restore.Enabled = true; ms_backup_delete.Enabled = true; //Enable backup controls
            }else //If not
            {
                ms_backup_restore.Enabled = false; ms_backup_delete.Enabled = false;//Disable backup controls
            }
        }

        private void ms_backup_restore_Click(object sender, EventArgs e)//If the restore backup button is pressed
        {
            string path = USM.DIR_BACKUPS + @"\" + lv_backups.SelectedItems[0].Tag.ToString(); //Set the path to the backups folder
            Save.set(path); //Restore the backup
            MessageBox.Show("Successfully restored from backup!"); //Tell the user
        }

        private void ms_create_Click(object sender, EventArgs e)//When the create backup button is pressed
        {
            string name = Prompt.ShowDialog("Please enter a name for the backup", "Backup - USMCE"); //Ask for a backup name
            if (!string.IsNullOrEmpty(name)) //If it is not empty
            {
                Random r = new Random(); //Create random instance
                string b = r.Next(0, 1000000).ToString(); //Create random number
                Save.backup(USM.DIR_BACKUPS + @"\bu_id_" + b, true, name, @"bu_id_" + b); //Create the backup
                refresh(); //Refresh the list
            }
            else //If the name is empty
            {
                MessageBox.Show("Name may not be empty"); //Tell the user the fucked up once again.. *Sigh*
            }
        }

        private void ms_backup_delete_Click(object sender, EventArgs e) //If the delete backup button has been pressed
        {
            /* remove from backups.xml */
            XDocument doc = XDocument.Load(USM.FILE_BACKUPSXML);
            foreach(XElement backup in doc.Element("Backups").Elements())
            {
                if(backup.Element("Dname").Value == lv_backups.SelectedItems[0].Tag.ToString())
                {
                    backup.Remove();
                    break;
                }
            }
            doc.Save(USM.FILE_BACKUPSXML);
            /* removed from backups.xml */
            /* Delete the backups directory */
            string path = USM.DIR_BACKUPS + @"\" + lv_backups.SelectedItems[0].Tag.ToString();
            Directory.Delete(path,true);
            refresh(); //Refresh
            //Disable the backup controls
            ms_backup_delete.Enabled = false;
            ms_backup_restore.Enabled = false;
        }
    }
}
