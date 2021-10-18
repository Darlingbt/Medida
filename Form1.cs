using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                convertir();
            }  
 
        }

        void convertir()
        {
            //Variables
            double kilogramos;
            double libras, gramos, decagramos, onzas, miligramos, tonelada, tonelam;
            
            //Entrada
            kilogramos = Convert.ToDouble(txtkg.Text);

            //Procesos
            libras = kilogramos * (2.20462);
            gramos = kilogramos * (1000);
            decagramos = kilogramos * (100);
            onzas = kilogramos * (35.2740);
            miligramos = kilogramos * (1000000);
            tonelada = kilogramos * (0.001);
            tonelam = kilogramos * (0.98);

            //Salida
            txtl.Text = Convert.ToString(libras);
            txtg.Text = Convert.ToString(gramos);
            txtdg.Text = Convert.ToString(decagramos);
            txto.Text = Convert.ToString(onzas);
            txtmg.Text = Convert.ToString(miligramos);
            txtt.Text = Convert.ToString(tonelada);
            txttm.Text = Convert.ToString(tonelam);
        }

        private void txtkg_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacion de un campo para que solo registre numero//
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            errorProvider1.SetError(txtkg, "");

        }

        private Boolean validar()
        {
            Boolean ok = true;
            
            if(txtkg.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtkg, "Ingresar cantidad de kilogramos");
            }
            return ok;

            
        }
    }
}
