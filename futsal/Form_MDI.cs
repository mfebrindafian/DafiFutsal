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
    public partial class Form_MDI : Form
    {
        FormPenyewaan frmPenyewaan;
        Riwayat_sewa rsPenyewaan;
        FormMember frmMember;
        public Form_MDI()
        {
            InitializeComponent();
        }

        private void formSewaBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPenyewaan = new FormPenyewaan();
            frmPenyewaan.MdiParent = this;
            frmPenyewaan.Show();
        }

        private void riwayatSewaLapanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rsPenyewaan = new Riwayat_sewa();
            rsPenyewaan.MdiParent = this;
            rsPenyewaan.Show();
        }

        private void formMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMember = new FormMember();
            frmMember.MdiParent = this;
            frmMember.Show();
        }
    }
}
