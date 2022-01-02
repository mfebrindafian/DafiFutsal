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
    public partial class FormMember : Form
    {
        static int id_member;
        public FormMember()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxKode_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewMember_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridViewMember.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewMember.Rows[selectedrowindex];
            textBoxNama.Text = Convert.ToString(selectedRow.Cells["nama"].Value);
            textBoxKTP.Text = Convert.ToString(selectedRow.Cells["no_ktp"].Value);
            textBoxHP.Text = Convert.ToString(selectedRow.Cells["no_hp"].Value);
            textBoxAlamat.Text = Convert.ToString(selectedRow.Cells["alamat"].Value);
            textBoxKode.Text = Convert.ToString(selectedRow.Cells["kode_anggota"].Value);
            textBoxTanggal.Text = Convert.ToString(selectedRow.Cells["tgl_daftar"].Value);
            textBoxBiaya.Text = Convert.ToString(selectedRow.Cells["biaya"].Value);
            id_member = Convert.ToInt32(selectedRow.Cells["id"].Value);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string response;
            Member member = new Member();
            response = member.Insert(nama: textBoxNama.Text, no_ktp: textBoxKTP.Text, no_hp: textBoxHP.Text, alamat: textBoxAlamat.Text, kode_anggota: textBoxKode.Text, tgl_daftar: textBoxTanggal.Text, biaya: Convert.ToInt32(textBoxBiaya.Text));
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
            textBoxKTP.Text = "";
            textBoxHP.Text = "";
            textBoxAlamat.Text = "";
            textBoxTanggal.Text = "";
        }
        private void reloadData()
        {
            Member member = new Member();
            DataTable dt = new DataTable();
            dt = member.ReadAll();
            dataGridViewMember.DataSource = dt;
            dataGridViewMember.Show();
        }

        private void btnLoadSewa_Click(object sender, EventArgs e)
        {
            reloadData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string response;
            DialogResult dialogResult = MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Member member = new Member();
                response = member.Delete(id: id_member);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string response;
            Member member = new Member();
            response = member.Update(id: id_member, nama: textBoxNama.Text, no_ktp: textBoxKTP.Text, no_hp: textBoxHP.Text, alamat: textBoxAlamat.Text, kode_anggota: textBoxKode.Text, tgl_daftar: textBoxTanggal.Text, biaya: Convert.ToInt32(textBoxBiaya.Text));
            if (response == null) MessageBox.Show("Data berhasil di update");
            else MessageBox.Show(response);
            reloadData();
            kosong();
        }
    }
}
