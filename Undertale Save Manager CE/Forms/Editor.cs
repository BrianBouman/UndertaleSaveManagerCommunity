using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Undertale_Save_Manager_CE
{
    public partial class Editor : Form
    {

        public string path { get; set; } = "";
        public Editor()
        {
            InitializeComponent(); //Load designer.cs
            this.MinimumSize = this.Size;
            tc_tabs.Enabled = false;  //Set the tab control to not respond
            foreach(string room in SaveInfo.rooms) //Add the list of rooms to the combobox room
            {
                dd_room.Items.Add(room);
            }
            //List of all slots
            List<ComboBox> slots = new List<ComboBox> {cb_armor,cb_weapon,cb_chest1,cb_chest2,cb_chest3,cb_chest4,cb_chest5,cb_chest6,cb_chest7,cb_chest8,cb_inv1,cb_inv2,cb_inv3,cb_inv4,cb_inv5,cb_inv6,cb_inv7,cb_inv8};
            foreach(ComboBox slot in slots) //Add the lists of items to each slot
            {
                foreach(string item in SaveInfo.items)
                {
                    slot.Items.Add(item);
                }
            }
        }
        
        private void Editor_Load(object sender, EventArgs e) //When the editor has finished loading
        {
            if (!string.IsNullOrEmpty(path)) //If the save is preset
            {
                if (Save.verify(path)) { //And valid
                    openSave(path); //Open that save
                }
            }
        }
        private void saveToSave()//Save the data to the save file
        {
            if(!string.IsNullOrEmpty(path)) //If the path is not empty
            {
                if (Directory.Exists(path)) //If it exists
                {
                    if(Save.verify(path)) //If it is valid
                    {
                        string[] lines = File.ReadAllLines(path + @"\file0"); //Get the lines to edit
                        Dictionary<string, string> info = new Dictionary<string, string> //Create the info for the writeSave function
                        {{"name", tb_name.Text},{"gold", tb_gold.Text},{"kills", tb_kills.Text},
                         {"item1", SaveInfo.itemtocode(cb_inv1.Text).ToString()},{"item2", SaveInfo.itemtocode(cb_inv2.Text).ToString()},
                         {"item3", SaveInfo.itemtocode(cb_inv3.Text).ToString()},{"item4", SaveInfo.itemtocode(cb_inv4.Text).ToString()},
                         {"item5", SaveInfo.itemtocode(cb_inv5.Text).ToString()},{"item6", SaveInfo.itemtocode(cb_inv6.Text).ToString()},
                         {"item7", SaveInfo.itemtocode(cb_inv7.Text).ToString()},{"item8", SaveInfo.itemtocode(cb_inv8.Text).ToString()},
                         {"chest1", SaveInfo.itemtocode(cb_chest1.Text).ToString()},
                         {"chest2", SaveInfo.itemtocode(cb_chest2.Text).ToString()},{"chest3", SaveInfo.itemtocode(cb_chest3.Text).ToString()},
                         {"chest4", SaveInfo.itemtocode(cb_chest4.Text).ToString()},{"chest5", SaveInfo.itemtocode(cb_chest5.Text).ToString()},
                         {"chest6", SaveInfo.itemtocode(cb_chest6.Text).ToString()},{"chest7", SaveInfo.itemtocode(cb_chest7.Text).ToString()},
                         {"chest8", SaveInfo.itemtocode(cb_chest8.Text).ToString()},{"weapon", SaveInfo.itemtocode(cb_weapon.Text).ToString()},
                         {"armor", SaveInfo.itemtocode(cb_armor.Text).ToString()},{"hp", slider_hp.Value.ToString()},
                         {"exp", slider_exp.Value.ToString()},{"lv", slider_lv.Value.ToString()},
                         {"room", SaveInfo.roomtocode(dd_room.Text).ToString()}
                        };
                        Save.writeSave(path + @"\file0", info); //Write to file0
                        Save.writeSave(path + @"\file9", info); //Write to file9
                        MessageBox.Show("Updated Save!"); //Tell the user
                    }
                }
            }
        }
        private void openSave(string save) //Open the save file
        {
            Dictionary<string, string> saveinfo = Save.readSave(save); //Read the save file
            /* Set all the slots, inputs, sliders to their coresponding value */
            cb_chest1.Text = SaveInfo.codetoitem(Convert.ToInt32(saveinfo["chest1"]));
            cb_chest2.Text = SaveInfo.codetoitem(Convert.ToInt32(saveinfo["chest2"]));
            cb_chest3.Text = SaveInfo.codetoitem(Convert.ToInt32(saveinfo["chest3"]));
            cb_chest4.Text = SaveInfo.codetoitem(Convert.ToInt32(saveinfo["chest4"]));
            cb_chest5.Text = SaveInfo.codetoitem(Convert.ToInt32(saveinfo["chest5"]));
            cb_chest6.Text = SaveInfo.codetoitem(Convert.ToInt32(saveinfo["chest6"]));
            cb_chest7.Text = SaveInfo.codetoitem(Convert.ToInt32(saveinfo["chest7"]));
            cb_chest8.Text = SaveInfo.codetoitem(Convert.ToInt32(saveinfo["chest8"]));
            cb_inv1.Text = SaveInfo.codetoitem(Convert.ToInt32(saveinfo["item1"]));
            cb_inv2.Text = SaveInfo.codetoitem(Convert.ToInt32(saveinfo["item2"]));
            cb_inv3.Text = SaveInfo.codetoitem(Convert.ToInt32(saveinfo["item3"]));
            cb_inv4.Text = SaveInfo.codetoitem(Convert.ToInt32(saveinfo["item4"]));
            cb_inv5.Text = SaveInfo.codetoitem(Convert.ToInt32(saveinfo["item5"]));
            cb_inv6.Text = SaveInfo.codetoitem(Convert.ToInt32(saveinfo["item6"]));
            cb_inv7.Text = SaveInfo.codetoitem(Convert.ToInt32(saveinfo["item7"]));
            cb_inv8.Text = SaveInfo.codetoitem(Convert.ToInt32(saveinfo["item8"]));
            tb_name.Text = saveinfo["name"];
            cb_weapon.Text = SaveInfo.codetoitem(Convert.ToInt32(saveinfo["weapon"]));
            cb_armor.Text = SaveInfo.codetoitem(Convert.ToInt32(saveinfo["armor"]));
            tb_kills.Text = saveinfo["kills"];
            tb_gold.Text = saveinfo["gold"];
            slider_exp.Value = Convert.ToInt32(saveinfo["exp"]);
            slider_hp.Value = Convert.ToInt32(saveinfo["hp"]);
            slider_lv.Value = Convert.ToInt32(saveinfo["lv"]);
            dd_room.Text = SaveInfo.codetoroom(Convert.ToInt32(saveinfo["room"]));
            labellv.Text = "Lv(" + slider_lv.Value.ToString() + "):";
            labelexp.Text = "Exp(" + slider_exp.Value.ToString() + "):";
            labelhp.Text = "Hp(" + slider_hp.Value.ToString() + "):";
            tc_tabs.Enabled = true; //Set the tab control to respond
        }
        private void ms_save_open_Click(object sender, EventArgs e) //When the open save button is clicked
        {
            DialogResult result = fbd_save_path.ShowDialog(); //Ask the user for a path to the save to edit
            if(result == DialogResult.OK) //If the user has entered a path
            {
                if(Directory.Exists(fbd_save_path.SelectedPath)) //If the path exists
                {
                    if (Save.verify(fbd_save_path.SelectedPath)) //If the save is valid
                    {
                        path = fbd_save_path.SelectedPath; //Set the path variable to the save path
                        openSave(path); //Open the save
                    }
                }
            }
        }

        /* ETC */

        private void ms_save_save_Click(object sender, EventArgs e)
        {
            saveToSave(); //Save changes
        }

        private void slider_lv_Scroll(object sender, EventArgs e)
        {
            labellv.Text = "Lv(" + slider_lv.Value.ToString() +"):";
        }

        private void slider_exp_Scroll(object sender, EventArgs e)
        {
            labelexp.Text = "Exp(" + slider_exp.Value.ToString() + "):";
        }

        private void slider_hp_Scroll(object sender, EventArgs e)
        {
            labelhp.Text = "Hp(" + slider_hp.Value.ToString() + "):";
        }
    }
}
