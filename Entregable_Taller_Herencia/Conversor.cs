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
  
    public partial class Conversor : Form
    {

        Miligramos miligramos = new Miligramos();
        Gramos gramos = new Gramos();
        Decagramos decagramos = new Decagramos();


        public Conversor()
        {
            InitializeComponent();
        }

        private void pbxsalir_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void btnmiligramos_Click(object sender, EventArgs e)
        {
            miligramos.setKilos(double.Parse(txtkilos.Text));

            lblresultado.Visible = true;
            lblresultado.Text = Convert.ToString(miligramos.mili());

        }

        private void btngramos_Click(object sender, EventArgs e)
        {
            gramos.setKilos(double.Parse(txtkilos.Text));

            lblresultado.Visible = true;
            lblresultado.Text = Convert.ToString(gramos.gramos());
        }

        private void btndecagramos_Click(object sender, EventArgs e)
        {
            decagramos.setKilos(double.Parse(txtkilos.Text));

            lblresultado.Visible = true;
            lblresultado.Text = Convert.ToString(decagramos.decagra());
        }
    }
}
