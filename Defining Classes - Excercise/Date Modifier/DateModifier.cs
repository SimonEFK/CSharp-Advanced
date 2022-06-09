using System;
using System.Collections.Generic;
using System.Text;

namespace Date_Modifier
{
    public static class DateModifier
    {
        public static int CalculateDaysDifferance(DateTime dateOne , DateTime dateTwo)
        {           
            return Math.Abs((dateOne - dateTwo).Days);
        }
    }
}
