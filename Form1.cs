using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
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

        private void soma_Click(object sender, EventArgs e)
        {
            string num1 = number1.Text;
            string num2 = number2.Text;
            int num1_inteiro = Int32.Parse(num1);
            int num2_inteiro = Int32.Parse(num2);
            int result = num1_inteiro + num2_inteiro;
            resultcampo.Text = result.ToString();
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            number1.Clear();
            number2.Clear();
            resultcampo.Clear();
        }

       
    }
}
