using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace EntitiesLayer
{
    public class Validaciones
    {
        public Boolean validarCamposTexto(RichTextBox textbox)
        {
            bool esNumerico;

            if (String.IsNullOrWhiteSpace(textbox.Text) == true)
            {
                esNumerico = false;
            }
            else
            {
            if (String.IsNullOrEmpty(textbox.Text) == true)
            {
                esNumerico = false;
            }
            else
            {
                if (Information.IsNumeric(textbox.Text) == true)
                {
                    esNumerico = false;
                }
                else
                {
                    esNumerico = true;
                }
            }
            }
                return esNumerico;
        }

        public Boolean validarCamposTexto(TextBox textbox)
        {
            bool esNumerico;

            if (String.IsNullOrWhiteSpace(textbox.Text) == true)
            {
                esNumerico = false;
            }
            else
            { 
            if (String.IsNullOrEmpty(textbox.Text) == true)
            {
                esNumerico = false;
            }
            else
            {
                if (Information.IsNumeric(textbox.Text) == true)
                {
                    esNumerico = false;
                }
                else
                {
                    esNumerico = true;
                }
            }
        }
            return esNumerico;
        }

        public Boolean validarCamposNumericos(TextBox textbox)
        {
            bool esTexto;

            if (String.IsNullOrWhiteSpace(textbox.Text) == true)
            {
                esTexto = false;
            }
            else
            { 
        
            if (String.IsNullOrEmpty(textbox.Text) == true)
            {
                esTexto = false;
            }
            else
            {
                if (Information.IsNumeric(textbox.Text) == true)
                {
                    esTexto = false;
                }
                else
                {
                    esTexto = true;
                }
            }
            
        }
                return esTexto;
        }

    }
}