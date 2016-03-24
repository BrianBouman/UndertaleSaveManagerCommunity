namespace Undertale_Save_Manager_CE
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ms_menu = new System.Windows.Forms.MenuStrip();
            this.uSMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_saves = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_usm_editor = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_usm_backups = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_ums_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_usm_about = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_save_set_presets = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_set_custom = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_save_edit_current = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_save_backup_normal = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_save_backup_as = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_save_clear = new System.Windows.Forms.ToolStripMenuItem();
            this.fbd_save_path = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_setave = new System.Windows.Forms.Button();
            this.cb_save = new System.Windows.Forms.ComboBox();
            this.label_1 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_lv = new System.Windows.Forms.Label();
            this.label_exp = new System.Windows.Forms.Label();
            this.label_room = new System.Windows.Forms.Label();
            this.ms_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_menu
            // 
            this.ms_menu.BackColor = System.Drawing.Color.White;
            this.ms_menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSMToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.ms_menu.Location = new System.Drawing.Point(0, 0);
            this.ms_menu.Name = "ms_menu";
            this.ms_menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ms_menu.Size = new System.Drawing.Size(584, 25);
            this.ms_menu.TabIndex = 0;
            this.ms_menu.Text = "Menu";
            // 
            // uSMToolStripMenuItem
            // 
            this.uSMToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.uSMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_saves,
            this.ms_usm_editor,
            this.ms_usm_backups,
            this.ms_ums_settings,
            this.ms_usm_about});
            this.uSMToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.uSMToolStripMenuItem.Name = "uSMToolStripMenuItem";
            this.uSMToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            this.uSMToolStripMenuItem.Text = "USM";
            // 
            // ms_saves
            // 
            this.ms_saves.Name = "ms_saves";
            this.ms_saves.Size = new System.Drawing.Size(123, 22);
            this.ms_saves.Text = "Saves";
            this.ms_saves.Click += new System.EventHandler(this.showSaves);
            // 
            // ms_usm_editor
            // 
            this.ms_usm_editor.Name = "ms_usm_editor";
            this.ms_usm_editor.Size = new System.Drawing.Size(123, 22);
            this.ms_usm_editor.Text = "Editor";
            this.ms_usm_editor.Click += new System.EventHandler(this.showEditor);
            // 
            // ms_usm_backups
            // 
            this.ms_usm_backups.Name = "ms_usm_backups";
            this.ms_usm_backups.Size = new System.Drawing.Size(123, 22);
            this.ms_usm_backups.Text = "Backups";
            this.ms_usm_backups.Click += new System.EventHandler(this.showBackups);
            // 
            // ms_ums_settings
            // 
            this.ms_ums_settings.Name = "ms_ums_settings";
            this.ms_ums_settings.Size = new System.Drawing.Size(123, 22);
            this.ms_ums_settings.Text = "Settings";
            this.ms_ums_settings.Click += new System.EventHandler(this.ms_ums_settings_Click);
            // 
            // ms_usm_about
            // 
            this.ms_usm_about.Name = "ms_usm_about";
            this.ms_usm_about.Size = new System.Drawing.Size(123, 22);
            this.ms_usm_about.Text = "About";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setToolStripMenuItem,
            this.editToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.ms_save_clear});
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // setToolStripMenuItem
            // 
            this.setToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_save_set_presets,
            this.ms_set_custom});
            this.setToolStripMenuItem.Name = "setToolStripMenuItem";
            this.setToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.setToolStripMenuItem.Text = "Set";
            // 
            // ms_save_set_presets
            // 
            this.ms_save_set_presets.Name = "ms_save_set_presets";
            this.ms_save_set_presets.Size = new System.Drawing.Size(150, 22);
            this.ms_save_set_presets.Text = "Presets";
            this.ms_save_set_presets.Click += new System.EventHandler(this.showSaves);
            // 
            // ms_set_custom
            // 
            this.ms_set_custom.Name = "ms_set_custom";
            this.ms_set_custom.Size = new System.Drawing.Size(150, 22);
            this.ms_set_custom.Text = "Custom save";
            this.ms_set_custom.Click += new System.EventHandler(this.setSaveCustom);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_save_edit_current});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // ms_save_edit_current
            // 
            this.ms_save_edit_current.Name = "ms_save_edit_current";
            this.ms_save_edit_current.Size = new System.Drawing.Size(119, 22);
            this.ms_save_edit_current.Text = "Current";
            this.ms_save_edit_current.Click += new System.EventHandler(this.showEditor_2);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_save_backup_normal,
            this.ms_save_backup_as});
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // ms_save_backup_normal
            // 
            this.ms_save_backup_normal.Name = "ms_save_backup_normal";
            this.ms_save_backup_normal.Size = new System.Drawing.Size(140, 22);
            this.ms_save_backup_normal.Text = "Backup";
            this.ms_save_backup_normal.Click += new System.EventHandler(this.backupNormal);
            // 
            // ms_save_backup_as
            // 
            this.ms_save_backup_as.Name = "ms_save_backup_as";
            this.ms_save_backup_as.Size = new System.Drawing.Size(140, 22);
            this.ms_save_backup_as.Text = "Backup as..";
            this.ms_save_backup_as.Click += new System.EventHandler(this.BackupAs);
            // 
            // ms_save_clear
            // 
            this.ms_save_clear.Name = "ms_save_clear";
            this.ms_save_clear.Size = new System.Drawing.Size(117, 22);
            this.ms_save_clear.Text = "Clear";
            this.ms_save_clear.Click += new System.EventHandler(this.clearSave);
            // 
            // fbd_save_path
            // 
            this.fbd_save_path.Description = "Please select a save";
            this.fbd_save_path.RootFolder = System.Environment.SpecialFolder.UserProfile;
            // 
            // btn_setave
            // 
            this.btn_setave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_setave.FlatAppearance.BorderSize = 0;
            this.btn_setave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_setave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setave.Location = new System.Drawing.Point(479, 133);
            this.btn_setave.Name = "btn_setave";
            this.btn_setave.Size = new System.Drawing.Size(93, 32);
            this.btn_setave.TabIndex = 2;
            this.btn_setave.Text = "Set";
            this.btn_setave.UseVisualStyleBackColor = false;
            this.btn_setave.Click += new System.EventHandler(this.btn_setave_Click);
            // 
            // cb_save
            // 
            this.cb_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cb_save.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_save.FormattingEnabled = true;
            this.cb_save.Location = new System.Drawing.Point(11, 133);
            this.cb_save.Name = "cb_save";
            this.cb_save.Size = new System.Drawing.Size(461, 32);
            this.cb_save.TabIndex = 14;
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1.ForeColor = System.Drawing.Color.Black;
            this.label_1.Location = new System.Drawing.Point(7, 25);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(144, 25);
            this.label_1.TabIndex = 15;
            this.label_1.Text = "Current Save:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.Black;
            this.label_name.Location = new System.Drawing.Point(7, 50);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(55, 20);
            this.label_name.TabIndex = 16;
            this.label_name.Text = "Name:";
            // 
            // label_lv
            // 
            this.label_lv.AutoSize = true;
            this.label_lv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lv.ForeColor = System.Drawing.Color.Black;
            this.label_lv.Location = new System.Drawing.Point(8, 70);
            this.label_lv.Name = "label_lv";
            this.label_lv.Size = new System.Drawing.Size(29, 20);
            this.label_lv.TabIndex = 17;
            this.label_lv.Text = "Lv:";
            // 
            // label_exp
            // 
            this.label_exp.AutoSize = true;
            this.label_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exp.ForeColor = System.Drawing.Color.Black;
            this.label_exp.Location = new System.Drawing.Point(8, 90);
            this.label_exp.Name = "label_exp";
            this.label_exp.Size = new System.Drawing.Size(40, 20);
            this.label_exp.TabIndex = 18;
            this.label_exp.Text = "Exp:";
            // 
            // label_room
            // 
            this.label_room.AutoSize = true;
            this.label_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_room.ForeColor = System.Drawing.Color.Black;
            this.label_room.Location = new System.Drawing.Point(8, 110);
            this.label_room.Name = "label_room";
            this.label_room.Size = new System.Drawing.Size(56, 20);
            this.label_room.TabIndex = 20;
            this.label_room.Text = "Room:";
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 172);
            this.Controls.Add(this.label_room);
            this.Controls.Add(this.label_exp);
            this.Controls.Add(this.label_lv);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.cb_save);
            this.Controls.Add(this.btn_setave);
            this.Controls.Add(this.ms_menu);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_menu;
            this.Name = "Main";
            this.Text = "Undertale Save Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ms_menu.ResumeLayout(false);
            this.ms_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_menu;
        private System.Windows.Forms.ToolStripMenuItem uSMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ms_save_set_presets;
        private System.Windows.Forms.ToolStripMenuItem ms_set_custom;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ms_save_edit_current;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ms_save_backup_normal;
        private System.Windows.Forms.ToolStripMenuItem ms_save_backup_as;
        private System.Windows.Forms.ToolStripMenuItem ms_save_clear;
        private System.Windows.Forms.ToolStripMenuItem ms_saves;
        private System.Windows.Forms.ToolStripMenuItem ms_usm_editor;
        private System.Windows.Forms.ToolStripMenuItem ms_usm_backups;
        private System.Windows.Forms.ToolStripMenuItem ms_ums_settings;
        private System.Windows.Forms.ToolStripMenuItem ms_usm_about;
        private System.Windows.Forms.FolderBrowserDialog fbd_save_path;
        private System.Windows.Forms.Button btn_setave;
        private System.Windows.Forms.ComboBox cb_save;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_lv;
        private System.Windows.Forms.Label label_exp;
        private System.Windows.Forms.Label label_room;
    }
}

