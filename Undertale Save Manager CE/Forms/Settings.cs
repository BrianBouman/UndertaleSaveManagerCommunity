using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Undertale_Save_Manager_CE
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent(); //Load designer.cs
            this.MinimumSize = this.Size;
        }
        public bool cbool(string b)//Convert bool string to bool
        {
            if(b.ToLower() == "true")
            {
                return true;
            }else
            {
                return false;
            }
        }

        private void Settings_Load(object sender, EventArgs e)//When the form has loaded
        {
            /* Load the settings.xml into the controls */
            XDocument doc = XDocument.Load(USM.FILE_SETTINGSXML);
            cb_createBackup.Checked = cbool(doc.Element("Settings").Element("CreateBackup").Value);
        }

        private void cb_createBackup_CheckedChanged(object sender, EventArgs e)//If the createbackup option is changed
        {
            //Update in settings.xml
            XDocument doc = XDocument.Load(USM.FILE_SETTINGSXML);
            doc.Element("Settings").Element("CreateBackup").Value = cb_createBackup.Checked.ToString();
            doc.Save(USM.FILE_SETTINGSXML);
        }

        private void btn_OpenCSaves_Click(object sender, EventArgs e)//Open Custom Saves folder
        {
            Process.Start(USM.DIR_CUSTOM_SAVES);
        }
    }
}
