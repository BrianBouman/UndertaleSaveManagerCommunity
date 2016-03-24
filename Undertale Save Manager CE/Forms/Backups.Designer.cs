namespace Undertale_Save_Manager_CE
{
    partial class frm_backups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_backups));
            this.ms_menu = new System.Windows.Forms.MenuStrip();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_backup_restore = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_backup_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_backup_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.lv_backups = new System.Windows.Forms.ListView();
            this.col_0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ms_create = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_menu
            // 
            this.ms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem});
            this.ms_menu.Location = new System.Drawing.Point(0, 0);
            this.ms_menu.Name = "ms_menu";
            this.ms_menu.Size = new System.Drawing.Size(484, 24);
            this.ms_menu.TabIndex = 0;
            this.ms_menu.Text = "Menu";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_create,
            this.ms_backup_restore,
            this.ms_backup_delete,
            this.ms_backup_exit});
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // ms_backup_restore
            // 
            this.ms_backup_restore.Name = "ms_backup_restore";
            this.ms_backup_restore.Size = new System.Drawing.Size(152, 22);
            this.ms_backup_restore.Text = "Restore";
            this.ms_backup_restore.Click += new System.EventHandler(this.ms_backup_restore_Click);
            // 
            // ms_backup_delete
            // 
            this.ms_backup_delete.Name = "ms_backup_delete";
            this.ms_backup_delete.Size = new System.Drawing.Size(152, 22);
            this.ms_backup_delete.Text = "Delete";
            this.ms_backup_delete.Click += new System.EventHandler(this.ms_backup_delete_Click);
            // 
            // ms_backup_exit
            // 
            this.ms_backup_exit.Name = "ms_backup_exit";
            this.ms_backup_exit.Size = new System.Drawing.Size(152, 22);
            this.ms_backup_exit.Text = "Exit";
            this.ms_backup_exit.Click += new System.EventHandler(this.ms_backup_exit_Click);
            // 
            // lv_backups
            // 
            this.lv_backups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_0,
            this.col_1,
            this.col_2});
            this.lv_backups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_backups.FullRowSelect = true;
            this.lv_backups.Location = new System.Drawing.Point(0, 24);
            this.lv_backups.Name = "lv_backups";
            this.lv_backups.Size = new System.Drawing.Size(484, 242);
            this.lv_backups.TabIndex = 2;
            this.lv_backups.UseCompatibleStateImageBehavior = false;
            this.lv_backups.View = System.Windows.Forms.View.Details;
            this.lv_backups.SelectedIndexChanged += new System.EventHandler(this.lv_backups_SelectedIndexChanged);
            // 
            // col_0
            // 
            this.col_0.Text = "name";
            // 
            // col_1
            // 
            this.col_1.Text = "date";
            // 
            // col_2
            // 
            this.col_2.Text = "time";
            // 
            // ms_create
            // 
            this.ms_create.Name = "ms_create";
            this.ms_create.Size = new System.Drawing.Size(152, 22);
            this.ms_create.Text = "Create";
            this.ms_create.Click += new System.EventHandler(this.ms_create_Click);
            // 
            // frm_backups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 266);
            this.Controls.Add(this.lv_backups);
            this.Controls.Add(this.ms_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_menu;
            this.Name = "frm_backups";
            this.Text = "Backups";
            this.Load += new System.EventHandler(this.Backups_Load);
            this.ms_menu.ResumeLayout(false);
            this.ms_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_menu;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ms_backup_restore;
        private System.Windows.Forms.ToolStripMenuItem ms_backup_delete;
        private System.Windows.Forms.ToolStripMenuItem ms_backup_exit;
        private System.Windows.Forms.ListView lv_backups;
        private System.Windows.Forms.ColumnHeader col_0;
        private System.Windows.Forms.ColumnHeader col_1;
        private System.Windows.Forms.ColumnHeader col_2;
        private System.Windows.Forms.ToolStripMenuItem ms_create;
    }
}