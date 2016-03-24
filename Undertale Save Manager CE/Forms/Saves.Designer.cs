namespace Undertale_Save_Manager_CE
{
    partial class frm_saves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_saves));
            this.ms_save = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_save_set = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_save_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.lv_saves = new System.Windows.Forms.ListView();
            this.col_0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ms_save.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_save
            // 
            this.ms_save.BackColor = System.Drawing.Color.White;
            this.ms_save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_save.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.ms_save.Location = new System.Drawing.Point(0, 0);
            this.ms_save.Name = "ms_save";
            this.ms_save.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ms_save.Size = new System.Drawing.Size(484, 25);
            this.ms_save.TabIndex = 0;
            this.ms_save.Text = "Menu";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_save_set,
            this.ms_save_exit});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // ms_save_set
            // 
            this.ms_save_set.Name = "ms_save_set";
            this.ms_save_set.Size = new System.Drawing.Size(152, 22);
            this.ms_save_set.Text = "Set Save";
            this.ms_save_set.Click += new System.EventHandler(this.ms_save_set_Click);
            // 
            // ms_save_exit
            // 
            this.ms_save_exit.Name = "ms_save_exit";
            this.ms_save_exit.Size = new System.Drawing.Size(152, 22);
            this.ms_save_exit.Text = "Exit";
            this.ms_save_exit.Click += new System.EventHandler(this.ms_save_exit_Click);
            // 
            // lv_saves
            // 
            this.lv_saves.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_0,
            this.col_1,
            this.col_2,
            this.col_3,
            this.col_4});
            this.lv_saves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_saves.Location = new System.Drawing.Point(0, 25);
            this.lv_saves.Name = "lv_saves";
            this.lv_saves.Size = new System.Drawing.Size(484, 241);
            this.lv_saves.TabIndex = 1;
            this.lv_saves.UseCompatibleStateImageBehavior = false;
            this.lv_saves.View = System.Windows.Forms.View.Details;
            this.lv_saves.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lv_saves_ColumnClick);
            this.lv_saves.SelectedIndexChanged += new System.EventHandler(this.lv_saves_SelectedIndexChanged);
            // 
            // col_0
            // 
            this.col_0.Text = "name";
            // 
            // col_1
            // 
            this.col_1.Text = "Lv";
            // 
            // col_2
            // 
            this.col_2.Text = "exp";
            // 
            // col_3
            // 
            this.col_3.Text = "hp";
            // 
            // col_4
            // 
            this.col_4.Text = "gold";
            // 
            // frm_saves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 266);
            this.Controls.Add(this.lv_saves);
            this.Controls.Add(this.ms_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_save;
            this.Name = "frm_saves";
            this.Text = "Saves";
            this.Load += new System.EventHandler(this.frm_saves_Load);
            this.ms_save.ResumeLayout(false);
            this.ms_save.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip ms_save;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ms_save_set;
        private System.Windows.Forms.ToolStripMenuItem ms_save_exit;
        private System.Windows.Forms.ListView lv_saves;
        private System.Windows.Forms.ColumnHeader col_0;
        private System.Windows.Forms.ColumnHeader col_1;
        private System.Windows.Forms.ColumnHeader col_2;
        private System.Windows.Forms.ColumnHeader col_3;
        private System.Windows.Forms.ColumnHeader col_4;
    }
}