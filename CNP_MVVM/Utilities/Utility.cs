using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNP_MVVM.Utilities
{
    public static class Utility
    {
        public static int GetMaxDays(int selectedIndex) // primeste ca argument SelectedItemLuni
        {
            switch (selectedIndex)
            {
                case 1: return 28;
                case 3:
                case 5:
                case 8:
                case 10: return 30;
                default: return 31;
            }
        } // returneaza numarul maxim de zile dintr-o luna
    }
}
