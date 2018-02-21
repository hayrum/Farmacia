﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_Avanzada 
{
    class ClaseEmpleados
    {
        public void LimpiarControles(Control LimpiarControles)
        {
            foreach (var txt in LimpiarControles.Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = 0;
                }
            }
        }
    }
}
