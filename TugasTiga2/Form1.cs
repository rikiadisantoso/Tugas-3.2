using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga2
{
    public partial class frmTugaTiga2 : Form
    {
        public frmTugaTiga2()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var Nama = txtNama.Text;
            var pendidikan = cmbPendidikan.Text;
            var pekerjaan = lstPekerjaan.Text;

            txtPesan1.Text = string.Format("Halo {0}", Nama);
            txtPesan2.Text = string.Format("Pendidikan anda {0}", pendidikan);
            txtPesan3.Text = string.Format("anda seorang {0}, hebat !!!!", pekerjaan);
        }
    }
}
