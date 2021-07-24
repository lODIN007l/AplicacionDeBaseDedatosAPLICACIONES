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
    public partial class FrmCursosDocente : Form {
        OperacionesLL ObjLlamar = new OperacionesLL();

        public FrmCursosDocente() {
            InitializeComponent();
        }

        private void reloadDataGrid() {
            if (DataGridView1.DataSource is DataTable) {
                ((DataTable)DataGridView1.DataSource).Rows.Clear();
                DataGridView1.Refresh();
            }
            DataGridView1.DataSource = ObjLlamar.mostrarDatos();
        }

        private void BtnAdd_Click(object sender, EventArgs e) {
            FrmAddCurso ObjAdd = new FrmAddCurso();
            ObjAdd.FormClosed += new System.Windows.Forms.FormClosedEventHandler(ObjReload_FormClosed);
            ObjAdd.ShowDialog();
        }

        private void ObjReload_FormClosed(object sender, FormClosedEventArgs e) {
            reloadDataGrid();
        }

        private void BtnModf_Click(object sender, EventArgs e) {
            FrmBuscModCurso ObjMod = new FrmBuscModCurso();
            ObjMod.FormClosed += new System.Windows.Forms.FormClosedEventHandler(ObjReload_FormClosed);
            ObjMod.ShowDialog();
        }

        private void BtnElim_Click(object sender, EventArgs e) {
            FrmBuscElimCurso ObjEli = new FrmBuscElimCurso();
            ObjEli.FormClosed += new System.Windows.Forms.FormClosedEventHandler(ObjReload_FormClosed);
            ObjEli.ShowDialog();
        }

        public void FrmCursosDocente_Load(object sender, EventArgs e) {
            reloadDataGrid();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
