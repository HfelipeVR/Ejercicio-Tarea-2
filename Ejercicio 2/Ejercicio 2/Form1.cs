using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CalProm1_Click(object sender, EventArgs e)
        {
            decimal Nota1 = 0;
            decimal Nota2 = 0;
            decimal Nota3 = 0;
            decimal Nota4 = 0;
            Nota1 = Convert.ToDecimal( NotaTexBox1.Text);
            Nota2 = Convert.ToDecimal(NotaTexBox2.Text);
            Nota3 = Convert.ToDecimal(NotaTexBox3.Text);
            Nota4 = Convert.ToDecimal(NotaTexBox4.Text);

            decimal Promedio = (Nota1 + Nota2 + Nota3 + Nota4)/4;

            MessageBox.Show( "El Pormedio del Alumno es: "+ Promedio);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
