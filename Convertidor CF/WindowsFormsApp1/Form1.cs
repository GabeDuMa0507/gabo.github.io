using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Conversor : Form
    {
        int bandera = 0;

        public Conversor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            try
            {
                double grados;
                //Si escribio en grados centigrados
                if (bandera == 1)
                {
                    //Centigrados
                    grados = Convert.ToDouble(gradosCbox.Text) * 9.0 / 5.0 + 32.0;
                    //Mostrar el resultado
                    gradosFbox.Text = String.Format("{0:F2}", grados);
                }
                if (bandera == 2)
                {
                    //Fahrenheit
                    grados = (Convert.ToDouble(gradosFbox.Text) - 32.0) * 5.0 / 9.0;
                    //Mostrar el resultado
                    gradosCbox.Text = String.Format("{0:F2}", grados);
                }
            }
            catch (FormatException) /*FormatException es una Clase*/
            {
                gradosCbox.Text = "0.0";
                gradosFbox.Text = "32.0";
            }
        }

        private void gradosCbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bandera = 1;
            if (e.KeyChar == 13)
            {
                btnaceptar_Click(sender, e);
            }
        }

        private void gradosFbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bandera = 2;
            if (e.KeyChar==13)
            {
                btnaceptar_Click(sender, e);
            }
        }

        private void Conversor_Leave(object sender, EventArgs e)
        {

        }

        private void Conversor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
