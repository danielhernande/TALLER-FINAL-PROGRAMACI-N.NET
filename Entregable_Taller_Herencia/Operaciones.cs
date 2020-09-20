using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Entregable_Taller_Herencia
{
    public partial class Operaciones : Form
    {
        Suma suma = new Suma();
        Resta resta = new Resta();
        Multiplicacion multiplicacion = new Multiplicacion();
        Division division = new Division();



        public Operaciones()
        {
            InitializeComponent();
        }

        private void pbxsalir_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            suma.setNumero1(double.Parse(txtnumero1.Text));
            suma.setNumero2(double.Parse(txtnumero2.Text));

            lblresultado.Visible = true;
            lblresultado.Text = Convert.ToString(suma.suma());

        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            resta.setNumero1(double.Parse(txtnumero1.Text));
            resta.setNumero2(double.Parse(txtnumero2.Text));

            lblresultado.Visible = true;
            lblresultado.Text = Convert.ToString(resta.resta());


        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            multiplicacion.setNumero1(double.Parse(txtnumero1.Text));
            multiplicacion.setNumero2(double.Parse(txtnumero2.Text));

            lblresultado.Visible = true;
            lblresultado.Text = Convert.ToString(multiplicacion.multiplicacion());
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            division.setNumero1(double.Parse(txtnumero1.Text));
            division.setNumero2(double.Parse(txtnumero2.Text));

            lblresultado.Visible = true;
            lblresultado.Text = Convert.ToString(division.division());
        }
    }
}
    