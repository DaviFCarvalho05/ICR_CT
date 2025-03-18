using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icr_Treasury_Control.Classes
{
    internal class Radio
    {
        public string GetSelectedRadioButton(GroupBox Income_Type)
        {
            foreach (Control control in Income_Type.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text; // Ou outra propriedade relevante
                }
            }


            return null; // Nenhum botão selecionado
        }
    }
}
