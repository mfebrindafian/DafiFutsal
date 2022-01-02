
namespace futsal
{
    partial class Form_MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.penyewaanLapanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formSewaBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riwayatSewaLapanganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penyewaanLapanganToolStripMenuItem,
            this.memberToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1280, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // penyewaanLapanganToolStripMenuItem
            // 
            this.penyewaanLapanganToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formSewaBookingToolStripMenuItem,
            this.riwayatSewaLapanganToolStripMenuItem});
            this.penyewaanLapanganToolStripMenuItem.Name = "penyewaanLapanganToolStripMenuItem";
            this.penyewaanLapanganToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.penyewaanLapanganToolStripMenuItem.Text = "Penyewaan Lapangan";
            // 
            // formSewaBookingToolStripMenuItem
            // 
            this.formSewaBookingToolStripMenuItem.Name = "formSewaBookingToolStripMenuItem";
            this.formSewaBookingToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.formSewaBookingToolStripMenuItem.Text = "Form Sewa &&  booking";
            this.formSewaBookingToolStripMenuItem.Click += new System.EventHandler(this.formSewaBookingToolStripMenuItem_Click);
            // 
            // riwayatSewaLapanganToolStripMenuItem
            // 
            this.riwayatSewaLapanganToolStripMenuItem.Name = "riwayatSewaLapanganToolStripMenuItem";
            this.riwayatSewaLapanganToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.riwayatSewaLapanganToolStripMenuItem.Text = "Riwayat Sewa Lapangan";
            this.riwayatSewaLapanganToolStripMenuItem.Click += new System.EventHandler(this.riwayatSewaLapanganToolStripMenuItem_Click);
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formMemberToolStripMenuItem});
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.memberToolStripMenuItem.Text = "Member";
            // 
            // formMemberToolStripMenuItem
            // 
            this.formMemberToolStripMenuItem.Name = "formMemberToolStripMenuItem";
            this.formMemberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formMemberToolStripMenuItem.Text = "Form Member";
            this.formMemberToolStripMenuItem.Click += new System.EventHandler(this.formMemberToolStripMenuItem_Click);
            // 
            // Form_MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::futsal.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1280, 746);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1296, 785);
            this.Name = "Form_MDI";
            this.Text = "Form_MDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem penyewaanLapanganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formSewaBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riwayatSewaLapanganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formMemberToolStripMenuItem;
    }
}