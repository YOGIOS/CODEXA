using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CODEXA
{
    class Validacion
    { //LOGICA EN EL ENTRY 
        public void valLetter(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                { //verifica que lo ingresado sean letras
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))//hace que see pueda leer un espacio y poder borrar si es necesario
                {
                    e.Handled = false;

                }
                else //-------de no ser una letra lo que se ingresa no se podra escrbir 
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {

            }

        }
        public void vaNumer(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                { //verifica que lo ingresado sean letras
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))//hace que see pueda leer un espacio y poder borrar si es necesario
                {
                    e.Handled = false;

                }
                else //-------de no ser una letra lo que se ingresa no se podra escrbir 
                {
                    e.Handled = true;
                }
            }
            catch (Exception es)
            {

            }
        }
    }
}