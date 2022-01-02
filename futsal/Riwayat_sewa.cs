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
    public partial class Riwayat_sewa : Form
    {
        static int id_penyewaan;
        public Riwayat_sewa()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            reloadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
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
        private void reloadData()
        {
            Penyewaan penyewaan = new Penyewaan();
            DataTable dt = new DataTable();
            dt = penyewaan.ReadAllSelesai();
            dataGridViewSelesai.DataSource = dt;
            dataGridViewSelesai.Show();
        }

        private void dataGridViewSelesai_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridViewSelesai.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewSelesai.Rows[selectedrowindex];
            id_penyewaan = Convert.ToInt32(selectedRow.Cells["id"].Value);
        }
    }
    }

