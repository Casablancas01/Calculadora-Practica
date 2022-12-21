using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_19_09_222
{
    public partial class BasicOperations : Form
    {
        private double num1;
        private double num2;
        
        public BasicOperations()
        {
            InitializeComponent();
        }

        #region Buttons
        private void btnmin_Click(object sender, EventArgs e)
        {
            if (Validatenumber())
            {
                var result = Minus(num1, num2);
                Printresult(result);
                Addresult("-", result);
                Cleaner();
            }

        }//boton Division.
        private void btnplus_Click(object sender, EventArgs e)
        {
            if (Validatenumber())
            {
                var result = Plus(num1, num2);
                Printresult(result);
                Addresult("+",result);
                txtnum1.Clear();
                txtnum2.Clear();
            }
        }//boton Sumar.
        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Deseas salir?", "Operaciones Basicas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes) this.Close();
        }//Boton SALIR.
        private void btndivide_Click(object sender, EventArgs e)
        {
            if (Validatenumber())
            {
                var result = division();                               
            }
        }//Boton Dividir.
        private void btnmulti_Click(object sender, EventArgs e)
        {
            if (Validatenumber())
            {
                var result = multiplecate();
                Printresult(result);
                Addresult("*", result);
                Cleaner();
            }
        }//boton Multiplicar
        private void btnCleanlts_Click(object sender, EventArgs e)
        {
            LstHistoryResult.Items.Clear();
        }//Boton limpia el list box.
        #endregion

        #region Operations
        private double Plus(double num1, double num2) => num1 + num2;//SUMA
        private double Minus(double n1, double n2) => n1 - n2;//RESTA
        private double multiplecate() => num1 * num2;// Multiplicar
        private double division()
        {
            double result = 0;
            if (num2 == 0)
            {
                ValidateError.SetError(txtnum2, "No se puede dividir por 0");
            }
            else
            {
                result = num1 / num2;
                Printresult(result);
                Addresult("%", result);
                Cleaner();
            }
            return result;
        }// Division
        #endregion

        #region Methods
        private bool Validatenumber()
        {
            bool valid = true;
            ValidateError.Clear();
            if (!double.TryParse(txtnum1.Text, out num1))
            {
                valid = false;
                ValidateError.SetError(txtnum1, "Numero 1 mal ingresado.");
            }

            if (!double.TryParse(txtnum2.Text, out num2))
            {
                valid = false;
                ValidateError.SetError(txtnum2, "Numero 2 mal ingresado.");
            }
            return valid;

        }//valida numeros
        private void Printresult(double result)
        {
            MessageBox.Show($"Result: {result.ToString("F")}", "Operaciones basicas");
        }//Imprime Resultado
        private void Addresult(string s, double r)
        {
            LstHistoryResult.Items.Add($"{num1}{s}{num2}={r.ToString("F")}");
        }//Adiciona las operaciones en el List Box
        private void Cleaner()
        {
            txtnum1.Clear();
            txtnum2.Clear();
        }//Limpia los Text Box
        #endregion
       

        

        

        private void BasicOperations_Load(object sender, EventArgs e)
        {

            LbDatetime.Text = DateTime.Now.ToString("f");
        }//Hora-Fecha
    }
}
