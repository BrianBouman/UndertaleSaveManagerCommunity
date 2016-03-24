using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Undertale_Save_Manager_CE
{
    public partial class frm_saves : Form
    {
        public frm_saves()
        {
            InitializeComponent(); //Load the designer.cs
            this.MaximumSize = this.Size; this.MinimumSize = this.Size;
            foreach (ColumnHeader col in lv_saves.Columns)
            {
                col.Width = (lv_saves.Width / lv_saves.Columns.Count); //Set the colums width to fit the listview
            }
        }

        private void frm_saves_Load(object sender, EventArgs e) //When the form has finished loading
        {
            string[] saves = Save.scanSaves(USM.DIR_SAVES);
            addSaves(saves);
            string[] csaves = Save.scanSaves(USM.DIR_CUSTOM_SAVES);
            addSaves(csaves);
        }
        private void addSaves(string[] saves)
        {
            foreach(string dir in saves) { 
                DirectoryInfo info = new DirectoryInfo(dir); //Get their directory info
                Dictionary<string, string> saveInfo = Save.readSave(dir); //Get the save info of each save
                string[] args = new string[] //Create the arguments for the listviewitem
                {
                            info.Name,
                            saveInfo["lv"],
                            saveInfo["exp"],
                            saveInfo["hp"],
                            saveInfo["gold"]
                };
                ListViewItem item = lv_saves.Items.Add(new ListViewItem(args)); //Add the save to the listview
                item.Tag = info.FullName; //Set the tag to the full path
            }
        }
        private void ms_save_exit_Click(object sender, EventArgs e) //Should speak for its self
        {
            this.Close();
        }

        private void lv_saves_SelectedIndexChanged(object sender, EventArgs e) //If the index of the selected item in the listview has changed
        {

            if (lv_saves.SelectedItems.Count > 0) //If an item is selected
            {
                ms_save_set.Enabled = true; //Enable save controls
            }
            else //When none is selected
            {
                ms_save_set.Enabled = false; //Disable save controls
            }
        }

        private void ms_save_set_Click(object sender, EventArgs e) //When the set save button is clicked
        {
            string path = lv_saves.SelectedItems[0].Tag.ToString(); //Set the path to the tag of the listviewitem (Wich is the full path)
            Save.set(path); //Set that save
            MessageBox.Show("Save successfully set!"); //Tell the user
        }

        private void lv_saves_ColumnClick(object sender, ColumnClickEventArgs e) //if a column is clicked sort the list to that column
        {
            lv_saves.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }
    }
    class ListViewItemComparer : IComparer //The sorter for the column click event
    {
        private int col;
        public ListViewItemComparer()
        {
            col = 0;
        }
        public ListViewItemComparer(int column)
        {
            col = column;
        }
        public int Compare(object x, object y)
        {
            return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
        }
    }
}
