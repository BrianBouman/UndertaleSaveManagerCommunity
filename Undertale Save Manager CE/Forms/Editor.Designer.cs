namespace Undertale_Save_Manager_CE
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.ms_menu = new System.Windows.Forms.MenuStrip();
            this.ms_save = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_save_save = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_save_open = new System.Windows.Forms.ToolStripMenuItem();
            this.tc_tabs = new System.Windows.Forms.TabControl();
            this.tp_general = new System.Windows.Forms.TabPage();
            this.dd_room = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelexp = new System.Windows.Forms.Label();
            this.slider_exp = new System.Windows.Forms.TrackBar();
            this.labellv = new System.Windows.Forms.Label();
            this.slider_lv = new System.Windows.Forms.TrackBar();
            this.labelhp = new System.Windows.Forms.Label();
            this.slider_hp = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_kills = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_gold = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.cb_armor = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cb_weapon = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_inv8 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_inv7 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_inv6 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_inv5 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_inv4 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_inv3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_inv2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_inv1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_chest8 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cb_chest7 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cb_chest6 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cb_chest5 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cb_chest4 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cb_chest3 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cb_chest2 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cb_chest1 = new System.Windows.Forms.ComboBox();
            this.fbd_save_path = new System.Windows.Forms.FolderBrowserDialog();
            this.ms_menu.SuspendLayout();
            this.tc_tabs.SuspendLayout();
            this.tp_general.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_exp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_lv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_hp)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_menu
            // 
            this.ms_menu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_save});
            this.ms_menu.Location = new System.Drawing.Point(0, 0);
            this.ms_menu.Name = "ms_menu";
            this.ms_menu.Size = new System.Drawing.Size(584, 28);
            this.ms_menu.TabIndex = 0;
            this.ms_menu.Text = "Menu";
            // 
            // ms_save
            // 
            this.ms_save.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_save_save,
            this.ms_save_open});
            this.ms_save.Name = "ms_save";
            this.ms_save.Size = new System.Drawing.Size(52, 24);
            this.ms_save.Text = "Save";
            // 
            // ms_save_save
            // 
            this.ms_save_save.Name = "ms_save_save";
            this.ms_save_save.Size = new System.Drawing.Size(114, 24);
            this.ms_save_save.Text = "Save";
            this.ms_save_save.Click += new System.EventHandler(this.ms_save_save_Click);
            // 
            // ms_save_open
            // 
            this.ms_save_open.Name = "ms_save_open";
            this.ms_save_open.Size = new System.Drawing.Size(114, 24);
            this.ms_save_open.Text = "Open";
            this.ms_save_open.Click += new System.EventHandler(this.ms_save_open_Click);
            // 
            // tc_tabs
            // 
            this.tc_tabs.Controls.Add(this.tp_general);
            this.tc_tabs.Controls.Add(this.tabPage3);
            this.tc_tabs.Controls.Add(this.tabPage1);
            this.tc_tabs.Controls.Add(this.tabPage2);
            this.tc_tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_tabs.Location = new System.Drawing.Point(0, 28);
            this.tc_tabs.Name = "tc_tabs";
            this.tc_tabs.SelectedIndex = 0;
            this.tc_tabs.Size = new System.Drawing.Size(584, 292);
            this.tc_tabs.TabIndex = 1;
            // 
            // tp_general
            // 
            this.tp_general.Controls.Add(this.dd_room);
            this.tp_general.Controls.Add(this.label4);
            this.tp_general.Controls.Add(this.labelexp);
            this.tp_general.Controls.Add(this.slider_exp);
            this.tp_general.Controls.Add(this.labellv);
            this.tp_general.Controls.Add(this.slider_lv);
            this.tp_general.Controls.Add(this.labelhp);
            this.tp_general.Controls.Add(this.slider_hp);
            this.tp_general.Controls.Add(this.label3);
            this.tp_general.Controls.Add(this.tb_kills);
            this.tp_general.Controls.Add(this.label2);
            this.tp_general.Controls.Add(this.tb_gold);
            this.tp_general.Controls.Add(this.label1);
            this.tp_general.Controls.Add(this.tb_name);
            this.tp_general.Location = new System.Drawing.Point(4, 22);
            this.tp_general.Name = "tp_general";
            this.tp_general.Padding = new System.Windows.Forms.Padding(3);
            this.tp_general.Size = new System.Drawing.Size(576, 266);
            this.tp_general.TabIndex = 0;
            this.tp_general.Text = "General";
            this.tp_general.UseVisualStyleBackColor = true;
            // 
            // dd_room
            // 
            this.dd_room.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dd_room.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dd_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dd_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dd_room.FormattingEnabled = true;
            this.dd_room.Location = new System.Drawing.Point(78, 186);
            this.dd_room.Name = "dd_room";
            this.dd_room.Size = new System.Drawing.Size(468, 32);
            this.dd_room.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Room:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelexp
            // 
            this.labelexp.AutoSize = true;
            this.labelexp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelexp.Location = new System.Drawing.Point(8, 108);
            this.labelexp.Name = "labelexp";
            this.labelexp.Size = new System.Drawing.Size(49, 24);
            this.labelexp.TabIndex = 11;
            this.labelexp.Text = "Exp:";
            this.labelexp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // slider_exp
            // 
            this.slider_exp.BackColor = System.Drawing.Color.White;
            this.slider_exp.LargeChange = 100;
            this.slider_exp.Location = new System.Drawing.Point(6, 135);
            this.slider_exp.Maximum = 99999;
            this.slider_exp.Name = "slider_exp";
            this.slider_exp.Size = new System.Drawing.Size(267, 45);
            this.slider_exp.SmallChange = 10;
            this.slider_exp.TabIndex = 10;
            this.slider_exp.Scroll += new System.EventHandler(this.slider_exp_Scroll);
            // 
            // labellv
            // 
            this.labellv.AutoSize = true;
            this.labellv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellv.Location = new System.Drawing.Point(281, 108);
            this.labellv.Name = "labellv";
            this.labellv.Size = new System.Drawing.Size(34, 24);
            this.labellv.TabIndex = 9;
            this.labellv.Text = "Lv:";
            this.labellv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // slider_lv
            // 
            this.slider_lv.BackColor = System.Drawing.Color.White;
            this.slider_lv.Location = new System.Drawing.Point(279, 135);
            this.slider_lv.Maximum = 20;
            this.slider_lv.Minimum = 1;
            this.slider_lv.Name = "slider_lv";
            this.slider_lv.Size = new System.Drawing.Size(267, 45);
            this.slider_lv.TabIndex = 8;
            this.slider_lv.Value = 1;
            this.slider_lv.Scroll += new System.EventHandler(this.slider_lv_Scroll);
            // 
            // labelhp
            // 
            this.labelhp.AutoSize = true;
            this.labelhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhp.Location = new System.Drawing.Point(281, 28);
            this.labelhp.Name = "labelhp";
            this.labelhp.Size = new System.Drawing.Size(40, 24);
            this.labelhp.TabIndex = 7;
            this.labelhp.Text = "Hp:";
            this.labelhp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // slider_hp
            // 
            this.slider_hp.BackColor = System.Drawing.Color.White;
            this.slider_hp.Location = new System.Drawing.Point(279, 55);
            this.slider_hp.Maximum = 99;
            this.slider_hp.Minimum = 1;
            this.slider_hp.Name = "slider_hp";
            this.slider_hp.Size = new System.Drawing.Size(267, 45);
            this.slider_hp.TabIndex = 6;
            this.slider_hp.Value = 1;
            this.slider_hp.Scroll += new System.EventHandler(this.slider_hp_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kills:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_kills
            // 
            this.tb_kills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_kills.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kills.Location = new System.Drawing.Point(78, 76);
            this.tb_kills.Name = "tb_kills";
            this.tb_kills.Size = new System.Drawing.Size(162, 29);
            this.tb_kills.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gold:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_gold
            // 
            this.tb_gold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_gold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gold.Location = new System.Drawing.Point(78, 41);
            this.tb_gold.Name = "tb_gold";
            this.tb_gold.Size = new System.Drawing.Size(162, 29);
            this.tb_gold.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_name
            // 
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(78, 6);
            this.tb_name.MaxLength = 6;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(162, 29);
            this.tb_name.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.cb_armor);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.cb_weapon);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(576, 266);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Weapon & Armor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(318, 13);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(62, 24);
            this.label23.TabIndex = 43;
            this.label23.Text = "Armor";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_armor
            // 
            this.cb_armor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_armor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_armor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_armor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_armor.FormattingEnabled = true;
            this.cb_armor.Location = new System.Drawing.Point(318, 40);
            this.cb_armor.Name = "cb_armor";
            this.cb_armor.Size = new System.Drawing.Size(250, 32);
            this.cb_armor.TabIndex = 42;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(8, 13);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(82, 24);
            this.label24.TabIndex = 41;
            this.label24.Text = "Weapon";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_weapon
            // 
            this.cb_weapon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_weapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_weapon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_weapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_weapon.FormattingEnabled = true;
            this.cb_weapon.Location = new System.Drawing.Point(8, 40);
            this.cb_weapon.Name = "cb_weapon";
            this.cb_weapon.Size = new System.Drawing.Size(250, 32);
            this.cb_weapon.TabIndex = 40;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.cb_inv8);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.cb_inv7);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.cb_inv6);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.cb_inv5);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.cb_inv4);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.cb_inv3);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.cb_inv2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cb_inv1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(576, 266);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Inventory";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(318, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 24);
            this.label11.TabIndex = 29;
            this.label11.Text = "Slot8:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_inv8
            // 
            this.cb_inv8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_inv8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_inv8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_inv8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_inv8.FormattingEnabled = true;
            this.cb_inv8.Location = new System.Drawing.Point(318, 218);
            this.cb_inv8.Name = "cb_inv8";
            this.cb_inv8.Size = new System.Drawing.Size(250, 32);
            this.cb_inv8.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(318, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 24);
            this.label12.TabIndex = 27;
            this.label12.Text = "Slot7:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_inv7
            // 
            this.cb_inv7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_inv7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_inv7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_inv7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_inv7.FormattingEnabled = true;
            this.cb_inv7.Location = new System.Drawing.Point(318, 160);
            this.cb_inv7.Name = "cb_inv7";
            this.cb_inv7.Size = new System.Drawing.Size(250, 32);
            this.cb_inv7.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(318, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 24);
            this.label13.TabIndex = 25;
            this.label13.Text = "Slot6:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_inv6
            // 
            this.cb_inv6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_inv6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_inv6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_inv6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_inv6.FormattingEnabled = true;
            this.cb_inv6.Location = new System.Drawing.Point(318, 98);
            this.cb_inv6.Name = "cb_inv6";
            this.cb_inv6.Size = new System.Drawing.Size(250, 32);
            this.cb_inv6.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(318, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 24);
            this.label14.TabIndex = 23;
            this.label14.Text = "Slot5:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_inv5
            // 
            this.cb_inv5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_inv5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_inv5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_inv5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_inv5.FormattingEnabled = true;
            this.cb_inv5.Location = new System.Drawing.Point(318, 36);
            this.cb_inv5.Name = "cb_inv5";
            this.cb_inv5.Size = new System.Drawing.Size(250, 32);
            this.cb_inv5.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "Slot4:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_inv4
            // 
            this.cb_inv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_inv4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_inv4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_inv4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_inv4.FormattingEnabled = true;
            this.cb_inv4.Location = new System.Drawing.Point(8, 218);
            this.cb_inv4.Name = "cb_inv4";
            this.cb_inv4.Size = new System.Drawing.Size(250, 32);
            this.cb_inv4.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Slot3:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_inv3
            // 
            this.cb_inv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_inv3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_inv3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_inv3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_inv3.FormattingEnabled = true;
            this.cb_inv3.Location = new System.Drawing.Point(8, 160);
            this.cb_inv3.Name = "cb_inv3";
            this.cb_inv3.Size = new System.Drawing.Size(250, 32);
            this.cb_inv3.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Slot2:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_inv2
            // 
            this.cb_inv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_inv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_inv2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_inv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_inv2.FormattingEnabled = true;
            this.cb_inv2.Location = new System.Drawing.Point(8, 98);
            this.cb_inv2.Name = "cb_inv2";
            this.cb_inv2.Size = new System.Drawing.Size(250, 32);
            this.cb_inv2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Slot1:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_inv1
            // 
            this.cb_inv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_inv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_inv1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_inv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_inv1.FormattingEnabled = true;
            this.cb_inv1.Location = new System.Drawing.Point(8, 36);
            this.cb_inv1.Name = "cb_inv1";
            this.cb_inv1.Size = new System.Drawing.Size(250, 32);
            this.cb_inv1.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.cb_chest8);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.cb_chest7);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.cb_chest6);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.cb_chest5);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.cb_chest4);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.cb_chest3);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.cb_chest2);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.cb_chest1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(576, 266);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Chest";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(318, 195);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 24);
            this.label15.TabIndex = 45;
            this.label15.Text = "Slot8:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_chest8
            // 
            this.cb_chest8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_chest8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_chest8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_chest8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_chest8.FormattingEnabled = true;
            this.cb_chest8.Location = new System.Drawing.Point(318, 218);
            this.cb_chest8.Name = "cb_chest8";
            this.cb_chest8.Size = new System.Drawing.Size(250, 32);
            this.cb_chest8.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(318, 133);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 24);
            this.label16.TabIndex = 43;
            this.label16.Text = "Slot7:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_chest7
            // 
            this.cb_chest7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_chest7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_chest7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_chest7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_chest7.FormattingEnabled = true;
            this.cb_chest7.Location = new System.Drawing.Point(318, 160);
            this.cb_chest7.Name = "cb_chest7";
            this.cb_chest7.Size = new System.Drawing.Size(250, 32);
            this.cb_chest7.TabIndex = 42;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(318, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 24);
            this.label17.TabIndex = 41;
            this.label17.Text = "Slot6:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_chest6
            // 
            this.cb_chest6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_chest6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_chest6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_chest6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_chest6.FormattingEnabled = true;
            this.cb_chest6.Location = new System.Drawing.Point(318, 98);
            this.cb_chest6.Name = "cb_chest6";
            this.cb_chest6.Size = new System.Drawing.Size(250, 32);
            this.cb_chest6.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(318, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 24);
            this.label18.TabIndex = 39;
            this.label18.Text = "Slot5:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_chest5
            // 
            this.cb_chest5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_chest5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_chest5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_chest5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_chest5.FormattingEnabled = true;
            this.cb_chest5.Location = new System.Drawing.Point(318, 36);
            this.cb_chest5.Name = "cb_chest5";
            this.cb_chest5.Size = new System.Drawing.Size(250, 32);
            this.cb_chest5.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(8, 195);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 24);
            this.label19.TabIndex = 37;
            this.label19.Text = "Slot4:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_chest4
            // 
            this.cb_chest4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_chest4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_chest4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_chest4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_chest4.FormattingEnabled = true;
            this.cb_chest4.Location = new System.Drawing.Point(8, 218);
            this.cb_chest4.Name = "cb_chest4";
            this.cb_chest4.Size = new System.Drawing.Size(250, 32);
            this.cb_chest4.TabIndex = 36;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(8, 133);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 24);
            this.label20.TabIndex = 35;
            this.label20.Text = "Slot3:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_chest3
            // 
            this.cb_chest3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_chest3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_chest3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_chest3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_chest3.FormattingEnabled = true;
            this.cb_chest3.Location = new System.Drawing.Point(8, 160);
            this.cb_chest3.Name = "cb_chest3";
            this.cb_chest3.Size = new System.Drawing.Size(250, 32);
            this.cb_chest3.TabIndex = 34;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(8, 71);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 24);
            this.label21.TabIndex = 33;
            this.label21.Text = "Slot2:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_chest2
            // 
            this.cb_chest2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_chest2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_chest2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_chest2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_chest2.FormattingEnabled = true;
            this.cb_chest2.Location = new System.Drawing.Point(8, 98);
            this.cb_chest2.Name = "cb_chest2";
            this.cb_chest2.Size = new System.Drawing.Size(250, 32);
            this.cb_chest2.TabIndex = 32;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(8, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 24);
            this.label22.TabIndex = 31;
            this.label22.Text = "Slot1:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_chest1
            // 
            this.cb_chest1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_chest1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_chest1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_chest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_chest1.FormattingEnabled = true;
            this.cb_chest1.Location = new System.Drawing.Point(8, 36);
            this.cb_chest1.Name = "cb_chest1";
            this.cb_chest1.Size = new System.Drawing.Size(250, 32);
            this.cb_chest1.TabIndex = 30;
            // 
            // fbd_save_path
            // 
            this.fbd_save_path.Description = "Please select a save";
            this.fbd_save_path.RootFolder = System.Environment.SpecialFolder.UserProfile;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 320);
            this.Controls.Add(this.tc_tabs);
            this.Controls.Add(this.ms_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_menu;
            this.Name = "Editor";
            this.Text = "Save Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.ms_menu.ResumeLayout(false);
            this.ms_menu.PerformLayout();
            this.tc_tabs.ResumeLayout(false);
            this.tp_general.ResumeLayout(false);
            this.tp_general.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_exp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_lv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_hp)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_menu;
        private System.Windows.Forms.ToolStripMenuItem ms_save;
        private System.Windows.Forms.ToolStripMenuItem ms_save_open;
        private System.Windows.Forms.TabControl tc_tabs;
        private System.Windows.Forms.TabPage tp_general;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_kills;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_gold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label labelexp;
        private System.Windows.Forms.TrackBar slider_exp;
        private System.Windows.Forms.Label labellv;
        private System.Windows.Forms.TrackBar slider_lv;
        private System.Windows.Forms.Label labelhp;
        private System.Windows.Forms.TrackBar slider_hp;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox dd_room;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_inv1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_inv4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_inv3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_inv2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_inv8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_inv7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_inv6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cb_inv5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cb_chest8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cb_chest7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cb_chest6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cb_chest5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cb_chest4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cb_chest3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cb_chest2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cb_chest1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cb_armor;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cb_weapon;
        private System.Windows.Forms.FolderBrowserDialog fbd_save_path;
        private System.Windows.Forms.ToolStripMenuItem ms_save_save;
    }
}