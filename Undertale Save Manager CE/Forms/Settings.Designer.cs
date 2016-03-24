namespace Undertale_Save_Manager_CE
{
    partial class Settings
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
            this.cb_createBackup = new System.Windows.Forms.CheckBox();
            this.btn_done = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_OpenCSaves = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_createBackup
            // 
            this.cb_createBackup.AutoSize = true;
            this.cb_createBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_createBackup.Location = new System.Drawing.Point(12, 12);
            this.cb_createBackup.Name = "cb_createBackup";
            this.cb_createBackup.Size = new System.Drawing.Size(260, 22);
            this.cb_createBackup.TabIndex = 0;
            this.cb_createBackup.Text = "Create Backup Before Aplying Save";
            this.cb_createBackup.UseVisualStyleBackColor = true;
            this.cb_createBackup.CheckedChanged += new System.EventHandler(this.cb_createBackup_CheckedChanged);
            // 
            // btn_done
            // 
            this.btn_done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_done.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_done.FlatAppearance.BorderSize = 0;
            this.btn_done.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_done.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_done.ForeColor = System.Drawing.Color.White;
            this.btn_done.Location = new System.Drawing.Point(188, 3);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(93, 32);
            this.btn_done.TabIndex = 3;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btn_done);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 88);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 38);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btn_OpenCSaves
            // 
            this.btn_OpenCSaves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_OpenCSaves.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OpenCSaves.FlatAppearance.BorderSize = 0;
            this.btn_OpenCSaves.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_OpenCSaves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenCSaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenCSaves.ForeColor = System.Drawing.Color.White;
            this.btn_OpenCSaves.Location = new System.Drawing.Point(12, 40);
            this.btn_OpenCSaves.Name = "btn_OpenCSaves";
            this.btn_OpenCSaves.Size = new System.Drawing.Size(260, 32);
            this.btn_OpenCSaves.TabIndex = 4;
            this.btn_OpenCSaves.Text = "Open custom saves folder";
            this.btn_OpenCSaves.UseVisualStyleBackColor = false;
            this.btn_OpenCSaves.Click += new System.EventHandler(this.btn_OpenCSaves_Click);
            // 
            // Settings
            // 
            this.AcceptButton = this.btn_done;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 126);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_OpenCSaves);
            this.Controls.Add(this.cb_createBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_createBackup;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_OpenCSaves;
    }
}