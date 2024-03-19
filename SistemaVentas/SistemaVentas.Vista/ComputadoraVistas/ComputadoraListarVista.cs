using SistemaVentas.Bss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.Vista.ComputadoraVistas
{
    public partial class ComputadoraListarVista : Form
    {
        public ComputadoraListarVista()
        {
            InitializeComponent();
        }
        ComputadoraBss bss = new ComputadoraBss();
        private void ComputadoraListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarComputadoraBss();
        }
    }
}
