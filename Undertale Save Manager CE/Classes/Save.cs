using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Undertale_Save_Manager_CE
{
    class Save
    {
        static public string[] savemap = new string[] { "file0", "file9", "undertale.ini" }; //Files needed in a valid save
        static public string[] savemapext = new string[] { "system_information_962", "system_information_963" }; //Genocide triggers

        static public bool verify(string path) //Verify if a save is valid
        {
            bool r = true;
            foreach (string file in savemap)
            {
                if (!File.Exists(path + @"\" + file))
                {
                    r = false;
                }
            }
            return r;
        }
        static public void reset() //Reset the save in the undertale directory
        {
            string[] files = Directory.GetFiles(USM.DIR_UNDERTALE);
            foreach (string file in files)
            {
                File.Delete(file);
            }
        }
        static public void set(string path) //Set the save to the selected path
        {
            if (USM.getSetting("CreateBackup") == "True")
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
                    MessageBox.Show("Backup has not been made: Name may not be empty. Canceled setting the save!");
                    return;
                }
            }
            if (verify(path))
            { //If the save file is valid
                string[] savefiles = Directory.GetFiles(path);
                string[] utfiles = Directory.GetFiles(USM.DIR_UNDERTALE);
                foreach (string file in utfiles)//Delete the current save files
                {
                    File.Delete(file);
                }
                foreach (string save in savefiles) //Replace them with the new ones
                {
                    FileInfo info = new FileInfo(save);
                    File.Copy(save, USM.DIR_UNDERTALE + @"\" + info.Name, true);
                }
            }
            else
            {
                MessageBox.Show("Invalid save"); //Tell the user something is wrong
            }
        }
        static public void backup(string path, bool addtoxml = false, string name = "", string dname = "")//Function to backup a save
        {
            if (!Directory.Exists(path)) //If the path does not exist
            {
                Directory.CreateDirectory(path); //Create it
            }
            else //If it exists
            {
                backup(path + "_2", addtoxml, name, dname + "_2"); //We don't want to mess with it so change the target dir
                return;
            }
            if (addtoxml) //If option addtoxml is set to true
            {
                string date = DateTime.Now.ToShortDateString(); //Get date
                string time = DateTime.Now.ToShortTimeString(); //Get time 

                XDocument doc = XDocument.Load(USM.FILE_BACKUPSXML); //Open backups.xml
                //Add the backup
                doc.Element("Backups").Add(
                    new XElement(
                        "Backup",
                        new XElement("Name", name),
                        new XElement("Date", date),
                        new XElement("Time", time),
                        new XElement("Dname", dname)
                    )
                );
                doc.Save(USM.FILE_BACKUPSXML);//Save to backups.xml
            }
            string[] utfiles = Directory.GetFiles(USM.DIR_UNDERTALE); //Get the current save files
            if (utfiles.Length > 0)
            { //If there are any
                foreach (string save in utfiles)//Back them up
                {
                    FileInfo info = new FileInfo(save);
                    File.Copy(save, path + @"\" + info.Name);
                }
            }
        }
        static public void writeSave(string save, Dictionary<string, string> savedata) //Write save data to save file
        {
            string[] lines = File.ReadAllLines(save); //Get current lines of the svae
            //Update them
            lines[1 - 1] = savedata["name"];
            lines[3 - 1] = savedata["hp"];
            lines[2 - 1] = savedata["lv"];
            lines[10 - 1] = savedata["exp"];
            lines[11 - 1] = savedata["gold"];
            lines[12 - 1] = savedata["kills"];
            lines[13 - 1] = savedata["item1"];
            lines[15 - 1] = savedata["item2"];
            lines[17 - 1] = savedata["item3"];
            lines[19 - 1] = savedata["item4"];
            lines[21 - 1] = savedata["item5"];
            lines[23 - 1] = savedata["item6"];
            lines[25 - 1] = savedata["item7"];
            lines[27 - 1] = savedata["item8"];
            lines[29 - 1] = savedata["weapon"];
            lines[30 - 1] = savedata["armor"];
            lines[331 - 1] = savedata["chest1"];
            lines[332 - 1] = savedata["chest2"];
            lines[333 - 1] = savedata["chest3"];
            lines[334 - 1] = savedata["chest4"];
            lines[335 - 1] = savedata["chest5"];
            lines[336 - 1] = savedata["chest6"];
            lines[337 - 1] = savedata["chest7"];
            lines[338 - 1] = savedata["chest7"];
            lines[548 - 1] = savedata["room"];
            File.WriteAllLines(save, lines); //Save changes to file
        }
        static public Dictionary<string, string> readSave(string path)//Function to read data from save
        {
            Dictionary<string, string> info = new Dictionary<string, string> { }; //Create the dictionary
            string[] lines = File.ReadAllLines(path + @"\file0"); //Read the lines from the saves
            //Create the data object from the save file's lines
            info["name"] = lines[1 - 1];
            info["hp"] = lines[3 - 1];
            info["lv"] = lines[2 - 1];
            info["exp"] = lines[10 - 1];
            info["gold"] = lines[11 - 1];
            info["kills"] = lines[12 - 1];
            info["item1"] = lines[13 - 1];
            info["item2"] = lines[15 - 1];
            info["item3"] = lines[17 - 1];
            info["item4"] = lines[19 - 1];
            info["item5"] = lines[21 - 1];
            info["item6"] = lines[23 - 1];
            info["item7"] = lines[25 - 1];
            info["item8"] = lines[27 - 1];
            info["weapon"] = lines[29 - 1];
            info["armor"] = lines[30 - 1];
            info["chest1"] = lines[331 - 1];
            info["chest2"] = lines[332 - 1];
            info["chest3"] = lines[333 - 1];
            info["chest4"] = lines[334 - 1];
            info["chest5"] = lines[335 - 1];
            info["chest6"] = lines[336 - 1];
            info["chest7"] = lines[337 - 1];
            info["chest8"] = lines[338 - 1];
            info["room"] = lines[548 - 1];
            return info; //Return the gained info
        }
        static public string[] scanSaves(string path)
        {
            List<string> saves = new List<string> { };
            foreach (string dir in Directory.GetDirectories(path)) //For all the directories in the saves directory
            {
                if (Save.verify(dir))
                {
                    saves.Add(dir);
                }
            }
            return saves.ToArray();
        }
    }
    class SaveInfo //The Save Info Management (Quick fact: this is the exact same as in the original project on my site :3)
    {
        /* List of all rooms in order */
        public static List<string> rooms = new List<string> { "Empty", "room_start", "room_introstory", "room_introimage", "room_intromenu", "room_area1", "room_area1_2", "room_ruins1", "room_ruins2", "room_ruins3", "room_ruins4", "room_ruins5", "room_ruins6", "room_ruins7", "room_ruins7A", "room_ruins8", "room_ruins9", "room_ruins10", "room_ruins11", "room_ruins12A", "room_ruins12", "room_ruins12B", "room_ruins13", "room_ruins14", "room_ruins15A", "room_ruins15B", "room_ruins15C", "room_ruins15D", "room_ruins15E", "room_ruins16", "room_ruins17", "room_ruins18OLD", "room_ruins19", "room_torhouse1", "room_torhouse2", "room_torhouse3", "room_torielroom", "room_asrielroom", "room_kitchen", "room_basement1", "room_basement2", "room_basement3", "room_basement4", "room_basement5", "room_ruinsexit", "room_tundra1", "room_tundra2", "room_tundra3", "room_tundra3A", "room_tundra4", "room_tundra5", "room_tundra6", "room_tundra6A", "room_tundra7", "room_tundra8", "room_tundra8A", "room_tundra9", "room_tundra_spaghetti", "room_tundra_snowpuzz", "room_tundra_xoxosmall", "room_tundra_xoxopuzz", "room_tundra_randoblock", "room_tundra_lesserdog", "room_tundra_icehole", "room_tundra_iceentrance", "room_tundra_iceexit_new", "room_tundra_iceexit", "room_tundra_poffzone", "room_tundra_dangerbridge", "room_tundra_town", "room_tundra_town2", "room_tundra_dock", "room_tundra_inn", "room_tundra_inn_2f", "room_tundra_grillby", "room_tundra_library", "room_tundra_garage", "room_tundra_sanshouse", "room_tundra_paproom", "room_tundra_sansroom", "room_tundra_sansroom_dark", "room_tundra_sansbasement", "room_fogroom", "room_water1", "room_water2", "room_water3", "room_water3A", "room_water4", "room_water_bridgepuzz1", "room_water5", "room_water5A", "room_water6", "room_water7", "room_water8", "room_water9", "room_water_savepoint1", "room_water11", "room_water_nicecream", "room_water12", "room_water_shoe", "room_water_bird", "room_water_onionsan", "room_water14", "room_water_piano", "room_water_dogroom", "room_water_statue", "room_water_prewaterfall", "room_water_waterfall", "room_water_waterfall2", "room_water_waterfall3", "room_water_waterfall4", "room_water_preundyne", "room_water_undynebridge", "room_water_undynebridgeend", "room_water_trashzone1", "room_water_trashsavepoint", "room_water_trashzone2", "room_water_friendlyhub", "room_water_undyneyard", "room_water_undynehouse", "room_water_blookyard", "room_water_blookhouse", "room_water_hapstablook", "room_water_farm", "room_water_prebird", "room_water_shop", "room_water_dock", "room_water15", "room_water16", "room_water_temvillage", "room_water17", "room_water18", "room_water19", "room_water20", "room_water21", "room_water_undynefinal", "room_water_undynefinal2", "room_water_undynefinal3", "room_fire1", "room_fire2", "room_fire_prelab", "room_fire_dock", "room_fire_lab1", "room_fire_lab2", "room_fire3", "room_fire5", "room_fire6", "room_fire6A", "room_fire_lasers1", "room_fire7", "room_fire8", "room_fire_shootguy_2", "room_fire9", "room_fire_shootguy_1", "room_fire_turn", "room_fire_cookingshow", "room_fire_savepoint1", "room_fire_elevator_r1", "room_fire_elevator_r2", "room_fire_hotdog", "room_fire_walkandbranch", "room_fire_sorry", "room_fire_apron", "room_fire10", "room_fire_rpuzzle", "room_fire_mewmew2", "room_fire_boysnightout", "room_fire_newsreport", "room_fire_coreview2", "room_fire_elevator_l2", "room_fire_elevator_l3", "room_fire_spidershop", "room_fire_walkandbranch2", "room_fire_conveyorlaser", "room_fire_shootguy_3", "room_fire_preshootguy4", "room_fire_shootguy_4", "room_fire_savepoint2", "room_fire_spider", "room_fire_pacing", "room_fire_operatest", "room_fire_multitile", "room_fire_hotelfront_1", "room_fire_hotelfront_2", "room_fire_hotellobby", "room_fire_restaurant", "room_fire_hoteldoors", "room_fire_hotelbed", "room_fire_elevator_r3", "room_fire_precore", "room_fire_core1", "room_fire_core2", "room_fire_core3", "room_fire_core4", "room_fire_core5", "room_fire_core_freebattle", "room_fire_core_laserfun", "room_fire_core_branch", "room_fire_core_bottomleft", "room_fire_core_left", "room_fire_core_topleft", "room_fire_core_top", "room_fire_core_topright", "room_fire_core_right", "room_fire_core_bottomright", "room_fire_core_center", "room_fire_shootguy_5", "room_fire_core_treasureleft", "room_fire_core_treasureright", "room_fire_core_warrior", "room_fire_core_bridge", "room_fire_core_premett", "room_fire_core_metttest", "room_fire_core_final", "room_fire_elevator", "room_fire_elevator_l1", "room_fire_finalelevator", "room_castle_elevatorout", "room_castle_precastle", "room_castle_hook", "room_castle_front", "room_asghouse1", "room_asghouse2", "room_asghouse3", "room_asgoreroom", "room_asrielroom_final", "room_kitchen_final", "room_basement1_final", "room_basement2_final", "room_basement3_final", "room_basement4_final", "room_lastruins_corridor", "room_sanscorridor", "room_castle_finalshoehorn", "room_castle_coffins1", "room_castle_coffins2", "room_castle_throneroom", "room_castle_prebarrier", "room_castle_barrier", "room_castle_exit", "room_undertale_end", "room_castle_trueexit", "room_outsideworld", "room_fire_labelevator", "room_truelab_elevatorinside", "room_truelab_elevator", "room_truelab_hall1", "room_truelab_hub", "room_truelab_hall2", "room_truelab_operatingroom", "room_truelab_redlever", "room_truelab_prebed", "room_truelab_bedroom", "room_truelab_mirror", "room_truelab_bluelever", "room_truelab_hall3", "room_truelab_shower", "room_truelab_determination", "room_truelab_tv", "room_truelab_cooler", "room_truelab_greenlever", "room_truelab_fan", "room_truelab_castle_elevator", "room_truelab_prepower", "room_truelab_power", "room_gaster", "room_icecave1", "room_ice_dog", "room2", "room_water_fakehallway", "room_mysteryman", "room_soundtest", "TESTROOM", "room_water_redacted", "room_water13", "room_overworld", "room_overworld3", "bullettest", "room_water16A", "room_end_castroll", "room_end_highway", "room_end_beach", "room_end_metta", "room_end_school", "room_end_mtebott", "room_creditsdodger", "room_end_myroom", "room_end_theend", "room_spritecheck", "room_joyconfig", "room_controltest", "room_f_start", "room_f_intro", "room_f_menu", "room_f_room", "room_floweyx", "room_f_phrase", "room_fire4", "room_fire10_old", "room_fire10A_old", "room_tundra_placeholder", "room_ruins12B_old", "room_tundra_rollsnow", "room_water7_older", "room_meetundyne_old", "room_water_mushroom", "room_monsteralign_test", "room_battle", "room_floweybattle", "room_fastbattle", "room_storybattle", "room_gameover", "room_shop1", "room_shop2", "room_shop3", "room_shop4", "room_shop5", "room_riverman_transition", "room_papdate", "room_adate", "room_flowey_endchoice", "room_flowey_regret", "room_empty", "room_emptywhite", "room_emptyblack", "room_nothingness", "room_undertale", "room_of_dog", "room_quizholder", "room_friendtest", "room_bringitinguys", "room_asrielappears", "room_goodbyeasriel", "room_asrielmemory", "room_asrieltest", "room_afinaltest" };
        /* List of all items in order */
        public static string[] items = new string[] { "Empty", "Monster Candy", "Croquet Roll", "Stick", "Bandage", "Rock Candy", "Pumpkin Rings", "Spider Donut", "Stoic Onion", "Ghost Fruit", "Spider Cider", "Butterscotch Pie", "Faded Ribbon", "Toy Knife", "Tough Clove", "Manly Bandana", "Snowman Piece", "Nice Cream", "Puppydough Icecream", "Bisicle", "Unicicle", "Cinnamon Bun", "Temmie Flakes", "Abandoned Quiche", "Old Tutu", "Ballet Shoes", "Punch Card", "Annoying Dog", "Dog Salad", "Dog Residue", "Dog Residue", "Dog Residue", "Dog Residue", "Dog Residue", "Dog Residue", "Astronaut Food", "Instant Noodles", "Crab Apple", "Hot Dog…?", "Hot Cat", "Glamburger", "Sea Tea", "Starfait", "Legendary Hero", "Cloudy Glasses", "Torn Notebook", "Stained Apron", "Burnt Pan", "Cowboy Hat", "Empty Gun", "Heart Locket", "Worn Dagger", "Real Knife", "The Locket", "Bad Memmory", "Dream", "Undyne's Letter", "Undyne Letter EX", "Popato Chisps", "Junk Food", "Mystery Key", "Face Steak", "Hush Puppy", "Snail Pie", "temy armor" };
        //Those where a real pain to make (took me several hours) but payed off later
        public static int roomtocode(string room) //Function to convert room name to the room code
        {
            var il = new Dictionary<string, int>();
            for (int i = 0; i < rooms.Count; i++)
            {
                il[rooms[i]] = i;
            }
            return il[room];
        }
        public static string codetoroom(int code)//Function to convert room code to room name
        {
            return rooms[code];
        }
        public static int itemtocode(string item) //Function to convert item name to item code
        {
            var il = new Dictionary<string, int>();
            for (int i = 0; i < items.Length; i++)
            {
                il[items[i]] = i;
            }
            return il[item];
        }
        public static string codetoitem(int code) //Function to convert item code to item name
        {
            return items[code];
        }
    }
}
