using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace promedio_estudiante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {


            string not1 = txtnota1.Text;
            string not2 = txtnota2.Text;
            string not3 = txtnota3.Text;
            string prom = lblprom.Text;

            float nota1 = float.Parse(not1);
            float nota2 = float.Parse(not2);
            float nota3 = float.Parse(not3);
            float promedio = (nota1 + nota2 + nota3) / 3;

            lblprom.Text = promedio.ToString();

        }
    }
}
