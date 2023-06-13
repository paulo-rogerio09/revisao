using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Divisao : Form
    {
        public Divisao()
        {
            InitializeComponent();
            lb_resultado.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(tx_valor_1.Text);
                int b = Convert.ToInt32(tx_valor_2.Text);

                int c = a / b;
                lb_resultado.Text = c.ToString();
                //MessageBox.Show(c.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro");
            }   
            finally
            {
                MessageBox.Show("vai de qualquer forma");
            }


        }

        private void radio_Click(object sender, EventArgs e)
        {
            string sexo = "";
            if(radioButton1.Checked )
            {
                sexo = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                sexo = radioButton2.Text;
            }
            MessageBox.Show(sexo);
        }
    }
}
