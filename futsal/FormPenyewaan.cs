using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futsal
{
    public partial class FormPenyewaan : Form
    {
        static int id_penyewaan;
        public FormPenyewaan()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string response;
            Penyewaan penyewaan = new Penyewaan();
            response = penyewaan.Insert(nama: textBoxNama.Text, tgl_sewa: textBoxTanggal.Text, lama_sewa: Convert.ToInt32(textBoxLama.Text), kode_lapangan: textBoxKode.Text, biaya: Convert.ToInt32(textBoxBiaya.Text), status: textBoxStatus.Text, jam_sewa: textBoxJam.Text); 
            if (response == null) MessageBox.Show("Data berhasil ditambahkan");
            else MessageBox.Show(response);
            reloadData();
            kosong();
        }

        private void kosong()
        {
            textBoxNama.Text = "";
            textBoxBiaya.Text = "";
            textBoxKode.Text = "";
            textBoxJam.Text = "";
            textBoxStatus.Text= "";
            textBoxLama.Text = "";
            textBoxTanggal.Text = "";
        }

        private void btnLoadSewa_Click(object sender, EventArgs e)
        {
            reloadData();
        }

        private void btnLoadBooking_Click(object sender, EventArgs e)
        {
            reloadData();
        }

        private void reloadData()
        {
            Penyewaan penyewaan = new Penyewaan();
            DataTable dt = new DataTable();
            dt = penyewaan.ReadAllSewa();
            dataGridViewSewa.DataSource = dt;
            dataGridViewSewa.Show();
            dt = penyewaan.ReadAllBooking();
            dataGridViewBooking.DataSource = dt;
            dataGridViewBooking.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string response;
            Penyewaan penyewaan = new Penyewaan();
            response = penyewaan.Update(id: id_penyewaan, nama: textBoxNama.Text, tgl_sewa: textBoxTanggal.Text, lama_sewa: Convert.ToInt32(textBoxLama.Text), kode_lapangan: textBoxKode.Text, biaya: Convert.ToInt32(textBoxBiaya.Text), status: textBoxStatus.Text, jam_sewa: textBoxJam.Text);
            if (response == null) MessageBox.Show("Data berhasil di update");
            else MessageBox.Show(response);
            reloadData();
            kosong();
        }

        private void panel3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewSewa_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridViewSewa.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewSewa.Rows[selectedrowindex];
            textBoxNama.Text = Convert.ToString(selectedRow.Cells["nama"].Value);
            textBoxTanggal.Text = Convert.ToString(selectedRow.Cells["tgl_sewa"].Value);
            textBoxLama.Text = Convert.ToString(selectedRow.Cells["lama_sewa"].Value);
            textBoxKode.Text = Convert.ToString(selectedRow.Cells["kode_lapangan"].Value);
            textBoxBiaya.Text = Convert.ToString(selectedRow.Cells["biaya"].Value);
            textBoxStatus.Text = Convert.ToString(selectedRow.Cells["status"].Value);
            textBoxJam.Text = Convert.ToString(selectedRow.Cells["jam_sewa"].Value);
            id_penyewaan = Convert.ToInt32(selectedRow.Cells["id"].Value);
        }

        private void dataGridViewBooking_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridViewBooking.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewBooking.Rows[selectedrowindex];
            textBoxNama.Text = Convert.ToString(selectedRow.Cells["nama"].Value);
            textBoxTanggal.Text = Convert.ToString(selectedRow.Cells["tgl_sewa"].Value);
            textBoxLama.Text = Convert.ToString(selectedRow.Cells["lama_sewa"].Value);
            textBoxKode.Text = Convert.ToString(selectedRow.Cells["kode_lapangan"].Value);
            textBoxBiaya.Text = Convert.ToString(selectedRow.Cells["biaya"].Value);
            textBoxStatus.Text = Convert.ToString(selectedRow.Cells["status"].Value);
            textBoxJam.Text = Convert.ToString(selectedRow.Cells["jam_sewa"].Value);
            id_penyewaan = Convert.ToInt32(selectedRow.Cells["id"].Value);
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string response;
            DialogResult dialogResult = MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Penyewaan penyewaan = new Penyewaan();
                response = penyewaan.Delete(id: id_penyewaan);
                if (response == null) MessageBox.Show("Data berhasil di hapus");
                else MessageBox.Show(response);
                reloadData();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            kosong();
        }

       
    }
}