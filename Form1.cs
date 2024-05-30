using Figuras_DI22113.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_DI22113
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cuadrado_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Dibujo_Click(object sender, EventArgs e)
        {
            if (Cuadrado.Checked == true)
            {
                Zo_Di.Image = Resources.Cuadrado;
            }
            else if (Cubo.Checked == true)
            {
                Zo_Di.Image = Resources.Cubo;
            }
            else if (Triangulo.Checked == true)
            {
                Zo_Di.Image = Resources.Triangulo;
            }
            else if (Rectangulo.Checked == true)
            {
                Zo_Di.Image = Resources.Rectangulo;
            }
            else if (Esfera.Checked == true)
            {
                Zo_Di.Image = Resources.Esfera;
            }
            else if (Circulo.Checked == true)
            {
                Zo_Di.Image = Resources.C;
            }
            else
            {
                Zo_Di.Image = null;
            }

        }
    }
}
