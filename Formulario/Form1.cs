using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lista(txtProducto.Text);
        }

        public void lista(string product)
        {
            List<string> producto = new List<string>();

            producto.Add(product);

            foreach(string iteracion in producto)
            {
                dataGridView1.Rows.Add(iteracion);
            }

            txtProducto.Text = "";
        }
    }
}
