using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtNum.Text = ("");
            listTabuada.Items.Clear();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int num1, resultado, i;
            i = 1;
            num1 = int.Parse(txtNum.Text);
            while (i <= 10)
            {
                resultado = i * num1;
                listTabuada.Items.Add(String.Concat(num1, " x ", i, " = ", resultado));
                i++;
            }
        }
    }
}
