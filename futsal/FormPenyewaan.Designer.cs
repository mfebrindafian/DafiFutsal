
namespace futsal
{
    partial class FormPenyewaan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.textBoxBiaya = new System.Windows.Forms.TextBox();
            this.textBoxKode = new System.Windows.Forms.TextBox();
            this.textBoxLama = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxJam = new System.Windows.Forms.TextBox();
            this.textBoxTanggal = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridViewSewa = new System.Windows.Forms.DataGridView();
            this.dataGridViewBooking = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLoadSewa = new System.Windows.Forms.Button();
            this.btnLoadBooking = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSewa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Penyewa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tanggal Sewa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status Penyewaan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lama Sewa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kode Lapangan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pembayaran";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnHapus);
            this.panel1.Controls.Add(this.btnBatal);
            this.panel1.Controls.Add(this.btnSimpan);
            this.panel1.Controls.Add(this.textBoxBiaya);
            this.panel1.Controls.Add(this.textBoxKode);
            this.panel1.Controls.Add(this.textBoxLama);
            this.panel1.Controls.Add(this.textBoxStatus);
            this.panel1.Controls.Add(this.textBoxJam);
            this.panel1.Controls.Add(this.textBoxTanggal);
            this.panel1.Controls.Add(this.textBoxNama);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 590);
            this.panel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(333, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Form Penyewaan Lapangan Futsal";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.BackColor = System.Drawing.Color.SandyBrown;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUpdate.Location = new System.Drawing.Point(231, 505);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(217, 36);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHapus.BackColor = System.Drawing.Color.Red;
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnHapus.Location = new System.Drawing.Point(231, 547);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(217, 36);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBatal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBatal.Location = new System.Drawing.Point(9, 547);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(215, 36);
            this.btnBatal.TabIndex = 3;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSimpan.Location = new System.Drawing.Point(8, 505);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(217, 36);
            this.btnSimpan.TabIndex = 3;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // textBoxBiaya
            // 
            this.textBoxBiaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBiaya.Location = new System.Drawing.Point(193, 370);
            this.textBoxBiaya.Multiline = true;
            this.textBoxBiaya.Name = "textBoxBiaya";
            this.textBoxBiaya.Size = new System.Drawing.Size(235, 29);
            this.textBoxBiaya.TabIndex = 1;
            // 
            // textBoxKode
            // 
            this.textBoxKode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKode.Location = new System.Drawing.Point(157, 305);
            this.textBoxKode.Multiline = true;
            this.textBoxKode.Name = "textBoxKode";
            this.textBoxKode.Size = new System.Drawing.Size(271, 29);
            this.textBoxKode.TabIndex = 1;
            // 
            // textBoxLama
            // 
            this.textBoxLama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLama.Location = new System.Drawing.Point(156, 254);
            this.textBoxLama.Multiline = true;
            this.textBoxLama.Name = "textBoxLama";
            this.textBoxLama.Size = new System.Drawing.Size(43, 29);
            this.textBoxLama.TabIndex = 1;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(156, 197);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(271, 29);
            this.textBoxStatus.TabIndex = 1;
            // 
            // textBoxJam
            // 
            this.textBoxJam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJam.Location = new System.Drawing.Point(156, 155);
            this.textBoxJam.Multiline = true;
            this.textBoxJam.Name = "textBoxJam";
            this.textBoxJam.Size = new System.Drawing.Size(271, 29);
            this.textBoxJam.TabIndex = 1;
            // 
            // textBoxTanggal
            // 
            this.textBoxTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTanggal.Location = new System.Drawing.Point(155, 110);
            this.textBoxTanggal.Multiline = true;
            this.textBoxTanggal.Name = "textBoxTanggal";
            this.textBoxTanggal.Size = new System.Drawing.Size(272, 29);
            this.textBoxTanggal.TabIndex = 1;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNama.Location = new System.Drawing.Point(156, 69);
            this.textBoxNama.Multiline = true;
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(271, 29);
            this.textBoxNama.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(203, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Jam (Rp.50.000/jam)";
            this.label11.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(153, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Rp.";
            this.label7.Click += new System.EventHandler(this.label6_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Jam";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(298, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 16);
            this.label14.TabIndex = 0;
            this.label14.Click += new System.EventHandler(this.label13_Click);
            // 
            // dataGridViewSewa
            // 
            this.dataGridViewSewa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSewa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewSewa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSewa.Location = new System.Drawing.Point(3, 44);
            this.dataGridViewSewa.Name = "dataGridViewSewa";
            this.dataGridViewSewa.Size = new System.Drawing.Size(742, 250);
            this.dataGridViewSewa.TabIndex = 2;
            this.dataGridViewSewa.Click += new System.EventHandler(this.dataGridViewSewa_Click);
            // 
            // dataGridViewBooking
            // 
            this.dataGridViewBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBooking.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooking.Location = new System.Drawing.Point(3, 44);
            this.dataGridViewBooking.Name = "dataGridViewBooking";
            this.dataGridViewBooking.Size = new System.Drawing.Size(741, 236);
            this.dataGridViewBooking.TabIndex = 2;
            this.dataGridViewBooking.Click += new System.EventHandler(this.dataGridViewBooking_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(4, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "Daftar Sewa Lapangan";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(3, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "Daftar Booking Lapangan";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnLoadSewa
            // 
            this.btnLoadSewa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadSewa.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnLoadSewa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadSewa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSewa.Location = new System.Drawing.Point(613, 9);
            this.btnLoadSewa.Name = "btnLoadSewa";
            this.btnLoadSewa.Size = new System.Drawing.Size(132, 29);
            this.btnLoadSewa.TabIndex = 3;
            this.btnLoadSewa.Text = "Load Data Sewa";
            this.btnLoadSewa.UseVisualStyleBackColor = false;
            this.btnLoadSewa.Click += new System.EventHandler(this.btnLoadSewa_Click);
            // 
            // btnLoadBooking
            // 
            this.btnLoadBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadBooking.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnLoadBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadBooking.Location = new System.Drawing.Point(612, 4);
            this.btnLoadBooking.Name = "btnLoadBooking";
            this.btnLoadBooking.Size = new System.Drawing.Size(132, 34);
            this.btnLoadBooking.TabIndex = 3;
            this.btnLoadBooking.Text = "Load Data Booking";
            this.btnLoadBooking.UseVisualStyleBackColor = false;
            this.btnLoadBooking.Click += new System.EventHandler(this.btnLoadBooking_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.dataGridViewBooking);
            this.panel2.Controls.Add(this.btnLoadBooking);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(480, 316);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 287);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnLoadSewa);
            this.panel3.Controls.Add(this.dataGridViewSewa);
            this.panel3.Location = new System.Drawing.Point(479, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(748, 297);
            this.panel3.TabIndex = 6;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(153, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "(bermain/booking/selesai)";
            this.label13.Click += new System.EventHandler(this.label6_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(154, 337);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(261, 16);
            this.label15.TabIndex = 5;
            this.label15.Text = "(FS01/FS02/FS03/OU01/OU02/LP01/LP02)";
            // 
            // FormPenyewaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1239, 615);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1255, 654);
            this.MinimumSize = new System.Drawing.Size(1255, 654);
            this.Name = "FormPenyewaan";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSewa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxBiaya;
        private System.Windows.Forms.TextBox textBoxLama;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewSewa;
        private System.Windows.Forms.DataGridView dataGridViewBooking;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLoadSewa;
        private System.Windows.Forms.Button btnLoadBooking;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxJam;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxTanggal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxKode;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
    }
}

