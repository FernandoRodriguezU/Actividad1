using SistemaVentas.Bss;
using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaVentas.Vista.ComputadoraVistas
{
    public partial class ComputadoraInsertarVista : Form
    {
        public ComputadoraInsertarVista()
        {
            InitializeComponent();
        }
        ComputadoraBss bss= new ComputadoraBss();   
        private void button1_Click(object sender, EventArgs e)
        {
            Computadora c = new Computadora();
            c.NOMBRE = textBox1.Text;
            c.DESCRIPCION= textBox2.Text;
            c.PRECIO = textBox3.Text;
            c.FECHAFABRICACION = dateTimePicker1.Value;
            bss.InsertarComputadoraBss(c);
            MessageBox.Show("Se guardo correctamente la computadora");


        }
    }
}
