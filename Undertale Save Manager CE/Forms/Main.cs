using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Management;
using System.Collections.Generic;

namespace Undertale_Save_Manager_CE
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent(); //Load the main.designer.cs
            this.MaximumSize = this.Size;this.MinimumSize = this.Size;
        }
        List<string> saves = new List<string> { };
        private void Main_Load(object sender, EventArgs e)//When the form is done loading
        {
            USM.createDirs();//Create the needed directories
            USM.createFiles(); //Create the needed files
            if (Directory.GetDirectories(USM.DIR_SAVES).Count() < 64)//Check if a preset save is missing?
            {
                if(Directory.GetDirectories(USM.DIR_SAVES).Count() > 0)//If there are any saves
                {
                    foreach(string d in Directory.GetDirectories(USM.DIR_SAVES))//Foreach preset save
                    {
                        Directory.Delete(d,true); //Delete
                    }
                }
                GetSaveFiles.downloadSaves(USM.LINK_SAVEFILES); //Download the preset saves and extract them to the saves folder
            }
            foreach(string dir in Directory.GetDirectories(USM.DIR_SAVES))
            {
                DirectoryInfo info = new DirectoryInfo(dir);
                cb_save.Items.Add(info.Name);
                saves.Add(info.FullName);
            }
            refreshInfo();
        }

        private void showEditor_2(object sender, EventArgs e) //Open the current aplied save in the editor
        {
            Editor edit = new Editor(); //Create instance of the editor
            edit.path = USM.DIR_UNDERTALE; //Set the path to the undertale folder
            edit.ShowDialog(); //Open the editor
        }

        private void showEditor(object sender, EventArgs e) //Open the editor
        {
            Editor edit = new Editor(); //Create instance of the editor
            edit.ShowDialog(); //Open the editor
        }
        private void refreshInfo()//Get the info of the current save
        {
            if (Save.verify(USM.DIR_UNDERTALE)) { 
                Dictionary<string, string> info = Save.readSave(USM.DIR_UNDERTALE);
                label_name.Text = "Name: " + info["name"];
                label_lv.Text = "Lv: " + info["lv"];
                label_exp.Text = "Exp: " + info["exp"];
                label_room.Text = "Room: " + SaveInfo.codetoroom(Convert.ToInt32(info["room"]));
            }
        }
        private void showSaves(object sender, EventArgs e) //Open the preset saves list
        {
            frm_saves frm = new frm_saves(); //Create instance of the saves list
            frm.ShowDialog(); //Open the saves list
        }
        private void showBackups(object sender, EventArgs e) //Open the backups list
        {
            frm_backups frm = new frm_backups(); //Create instance of the backups list
            frm.ShowDialog(); //Show the backups lists
        }


        private void clearSave(object sender, EventArgs e) //Clear the save
        {
            Save.reset(); //Fire reset save function
            MessageBox.Show("Successfully reset save!"); //Tell the user
        }

        private void backupNormal(object sender, EventArgs e) //Show the prompt for the name andBackup the current save files 
        {
            string name = Prompt.ShowDialog("Please enter a name for the backup", "Backup - USMCE"); //Get a name for the backup
            if (!string.IsNullOrEmpty(name)) //If the name is valid
            {
                Random r = new Random(); //Create random instance
                string b = r.Next(0, 1000000).ToString(); //Create random number (This is so that backups have their own unique id)
                Save.backup(USM.DIR_BACKUPS + @"\bu_id_" + b, true, name, @"bu_id_" + b); //Call the backup function
            }
            else //If not
            {
                MessageBox.Show("Name may not be empty"); //Tell the user they fucked up
            }
        }

        private void setSaveCustom(object sender, EventArgs e)//Function to ask for a path to a save, validate if it is valid? set!
        {
            DialogResult result = fbd_save_path.ShowDialog();//Ask for the save's path
            if(result == DialogResult.OK)//If the dialog returns ok
            {
                string path = fbd_save_path.SelectedPath; //get the entered path
                if (Directory.Exists(path)) //if that paths exists
                {
                    if (Save.verify(path)) //Verify the save
                    {
                        Save.set(path); //Set the save
                        MessageBox.Show("Successfully set save!"); //Tell the user
                        refreshInfo();
                    }
                }
            }
        }

        private void BackupAs(object sender, EventArgs e)//Function to backup the current save to a specified folder
        {
            fbd_save_path.Description = "Please select a directory to backup to...";
            if(fbd_save_path.ShowDialog() == DialogResult.OK)
            {
                string path = fbd_save_path.SelectedPath;
                if (!string.IsNullOrEmpty(path))
                {
                    if (Directory.Exists(path))
                    {
                        Save.backup(path + @"\Backup");
                        MessageBox.Show("Successfully backed up to..." + path + @"\Backup!");
                    }
                }
            }
        }

        private void ms_ums_settings_Click(object sender, EventArgs e)//Opens settings dialog
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        //Set the save to the save selected
        private void btn_setave_Click(object sender, EventArgs e)
        {
            if(cb_save.SelectedIndex > 0) { 
                Save.set(saves[cb_save.SelectedIndex]);
            }
            refreshInfo();
        }
    }
}
