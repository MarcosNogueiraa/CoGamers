using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CoGamers.Util
{
    class Funcoes
    {
        public bool SingletonForms(Form form)
        {
            foreach (Form forms in Application.OpenForms)
            {
                if (forms.Name == form.Name)
                {
                    return true;
                }
            }
            form.Show();
            return false;
        }
    }
}
