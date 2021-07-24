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


namespace APLICACIONBASEDEDATOS
{
    public partial class pruebas : Form
    {
        OperacionesLL objLogica = new OperacionesLL();
        
        public pruebas()
        {
            InitializeComponent();
        }

        private void pruebas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = objLogica.MostrarUsuarios();
        }
    }
}
