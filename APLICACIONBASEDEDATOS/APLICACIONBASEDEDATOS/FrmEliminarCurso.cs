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
    public partial class FrmEliminarCurso : Form {
        OperacionesLL ObjLlamar = new OperacionesLL();
        public FrmEliminarCurso(int cod, string tit, string leng, string desc, string prec) {
            InitializeComponent();
            TxtCod.Text = cod.ToString();
            txtTitulo.Text = tit;
            txtLenguaje.Text = leng;
            txtDescripcion.Text = desc;
            txtPrecio.Text = prec;
        }

        private void BtnElim_Click(object sender, EventArgs e) {
            try {
                ObjLlamar.EliminarCurso(int.Parse(TxtCod.Text));
                MessageBox.Show("Curso eliminado correctamente");
                this.Close();
            }
            catch {
                MessageBox.Show("Curso no eliminado");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
