using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;

namespace APLICACIONBASEDEDATOS {
    public partial class FrmBuscModCurso : Form {
        OperacionesLL ObjLlamar = new OperacionesLL();
        public FrmBuscModCurso() {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            try {
                DataGridView2.DataSource = ObjLlamar.BuscarCurso(int.Parse(TxtCod.Text));
                MessageBox.Show("Curso encontrado correctamente");
            }
            catch {
                MessageBox.Show("Curso no encontrado");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void BtnPasModf_Click(object sender, EventArgs e) {
            string tit, leng, prec, descr;
            if (DataGridView2.SelectedRows.Count == 1) {
                tit = DataGridView2.CurrentRow.Cells["titulo"].Value.ToString();
                leng = DataGridView2.CurrentRow.Cells["lenguaje"].Value.ToString();
                descr = DataGridView2.CurrentRow.Cells["descripcion"].Value.ToString();
                prec = DataGridView2.CurrentRow.Cells["precio"].Value.ToString();

                FrmModificarCurso ObjMod = new FrmModificarCurso(int.Parse(TxtCod.Text), tit, leng, descr, prec);
                ObjMod.Show();
            }
        }
        public static void ValidarNumeros(KeyPressEventArgs V) {
            if (char.IsNumber(V.KeyChar))
                V.Handled = false;
            else if (char.IsControl(V.KeyChar))
                V.Handled = false;
            else if (char.IsPunctuation(V.KeyChar))
                V.Handled = false;
            else
                V.Handled = true;
        }

        private void TxtCod_KeyPress(object sender, KeyPressEventArgs e) {
            ValidarNumeros(e);
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
