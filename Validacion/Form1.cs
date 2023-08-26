using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validacion
    {
    public partial class Form1 :Form
        {
        public Form1()
            {
            InitializeComponent();
            }

        private void BtnPat_Click(object sender, EventArgs e)
            {
            string patron = @"^[A-Z]{3}\d{3}$";
            string patron2 = @"^[A-Z]{2}\d{3}[A-Z]{2}$";
            string input = txtBoxPat.Text;

            if (Regex.IsMatch(input, patron))
                {
                MessageBox.Show("Patente valida");
                }
            else if (Regex.IsMatch(input, patron2))
                {
                MessageBox.Show("Patente valida");
                }
            else
                {
                MessageBox.Show("Patente invalida");
                }
            ValidarPatVacio();

            }

        private void BtnCuil_Click(object sender, EventArgs e)
            {

            string cuil = txtBoxCuil.Text.Trim();
          

            if (cuil.Length == 11 && cuil.All(char.IsDigit))
                {
                string dni = cuil.Substring(2, 8); 
                string cuilFormateado = $"{cuil.Substring(0, 2)}-{cuil.Substring(2, 8)}-{cuil.Substring(10)}"; 
                string mensaje = "El CUIL ingresado es: " + cuilFormateado;
                string mensaje2 = "El DNI es: " + dni;
                MessageBox.Show(mensaje, "CUIL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(mensaje2, "DNI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            else
                {
                MessageBox.Show("Ingrese un CUIL válido de 11 números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            ValidarCuilVacio();
           
            }


        private bool ValidarCuilVacio()
            {
            bool ok = true;

            if (txtBoxCuil.Text == "")
                {
                ok = false;
                MessageBox.Show("Llene el campo vacio");
                }
            return ok;
            }

         private bool ValidarPatVacio()
             {
             bool ok = true;

             if (txtBoxPat.Text == "")
                 {
                 ok = false;
                 MessageBox.Show("Llene el campo vacio");
                 }
             return ok;
             }



//private bool ValidarPatente(string patente)
//            {
//            // Expresión regular para validar el formato "LLLNNN"
//            //string patron = @"^[A-Z]{3}\d{3}$";
//            //string patron2 = @"^[A-Z]{2}\d{3}[A-Z}{2}$";
//            //return Regex.IsMatch(patente, patron);
//            //return Regex.IsMatch(patron2, patron);
//            }

        private void txtBoxCuil_TextChanged(object sender, EventArgs e)
            {
            string input = txtBoxCuil.Text;
            string pattern = @"^\d+$";
            bool numerico = Regex.IsMatch(input, pattern);

            if (!numerico)
                {
                txtBoxCuil.Text = "";
                }
            }
        }
    }
