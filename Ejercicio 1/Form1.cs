using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {


        double conversion, total;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try { 

            conversion = Double.Parse(caja.Text);

            if (temp.Checked)
            {
                total= (conversion * 1.8) + 32 ;
                MessageBox.Show("La temperatura en Farenheit es: " + Math.Round(total, 2));
            }

            if (longitud.Checked)
            {
                Math.Round((total = conversion * 3.28084) , 2);
                MessageBox.Show("La medida en pies es: " + Math.Round(total, 2));
            }


            if (masa.Checked)
            {
                Math.Round((total = conversion * 2.20), 2);
                MessageBox.Show("La medida en libras es: " + Math.Round(total, 2));
            }

            }
            catch
            {
                MessageBox.Show("Verifique los datos ingresados");
            }
        }
    }
}
