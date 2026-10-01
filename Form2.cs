using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evaluacion_final__5top_c_maybelin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Btnproductos_Click(object sender, EventArgs e)
        {
            Byte Num1 = Byte.Parse(textvar1.Text);
            Byte Num2 = Byte.Parse(textVar2.Text);
            int Producto = Num1 * Num2;
            MessageBox.Show("El R// es " + Producto);
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            Byte Num1 = Byte.Parse(textvar1.Text);
            Byte Num2 = Byte.Parse(textVar2.Text);
            int Suma = Num1 + Num2;
            MessageBox.Show("El R// es " + Suma);
        }

        private void Btnpotencia_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(textvar1.Text);
            int Num2 = int.Parse(textVar2.Text);
            int Potencia = 1;
            int J = 0;
            while (J != Num2)
            {
                Potencia = Potencia * Num1;
                J++;
            }
            MessageBox.Show("El R// es" + Potencia);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textvar1.Text);
            int num2 = int.Parse(textVar2.Text);

          
   



        }
    }
}

 




