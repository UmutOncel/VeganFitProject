using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TextBoxs.TextBox;

namespace VeganFit.UI.UserOperation
{
    public static class RegularExcep
    {
        /// <summary>
        /// DesignTextbox'taki veri ile parametredeki string'in eşleşmesini kontrol eden ve sonucu boolean olarak döndüren metot. 
        /// </summary>
        /// <param name="rgx"></param>
        /// <param name="txtb"></param>
        /// <returns></returns>
        public static bool RegularEx(string rgx, DesignTextBox txtb)
        {
            bool control = false;
            Regex regex = new Regex(rgx);
            Match match = regex.Match(txtb.Text);
            if (match.Success)
            {
                control = true;
            }
            else
            {
                control = false;
            }
            return control;
        }
    }
}
