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
    public partial class FrmAddCurso : Form {
        OperacionesLL ObjLlamar = new OperacionesLL();
        string seleccion;
        public FrmAddCurso() {
            InitializeComponent();
        }

        #region CONTROLES
        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                string titulo = txtTitulo.Text;
                if (titulo.Length > 0) {
                    ComboBoxLeng.Focus();
                    txtTitulo.Enabled = false;
                }
                else {
                    MessageBox.Show("El titulo se encuentra vacío, ingrese uno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTitulo.Clear();
                }
            }
        }

        private void ComboBoxLeng_SelectedIndexChanged(object sender, EventArgs e) {
            seleccion = ComboBoxLeng.SelectedItem.ToString();
            txtPrecio.Focus();
            ComboBoxLeng.Enabled = false;
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                string descripcion = txtDescripcion.Text;
                if (descripcion.Length > 0) {
                    BtnAdd.Focus();
                    txtDescripcion.Enabled = false;
                }
                else {
                    MessageBox.Show("La descripción se encuentra vacío, ingrese algo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescripcion.Clear();
                }
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                try {
                    double precio = double.Parse(txtPrecio.Text);
                    if (precio > 0 && precio <= 1000) {
                        txtDescripcion.Focus();
                        txtPrecio.Enabled = false;
                    }
                    else {
                        MessageBox.Show("Solo se permiten valores entre 1 y 1000", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtPrecio.Clear();
                    }
                }
                catch {
                    MessageBox.Show("Solo se permiten valores entre 1 y 1000", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrecio.Clear();
                }
            }
        }

        #endregion

        #region BOTONES
        private void BtnAdd_Click(object sender, EventArgs e) {
            try {
                ObjLlamar.IngresarCurso(txtTitulo.Text, seleccion, txtDescripcion.Text, txtPrecio.Text);
                MessageBox.Show("Datos insertados correctamente");
                this.Close();
            }
            catch {
                MessageBox.Show("Datos no insertados");
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        #endregion

        private void guna2PictureBox2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
