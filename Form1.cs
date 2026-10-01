using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evaluacion_final__5top_c_maybelin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {
            if (textUsuario.Text == "magali" && textcontrasena.Text == "92")
            {
                this.Hide();
                Form2 aap = new Form2();
                aap.Show();
            }
            else
            {
            }
        }
    }
}