using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_homework1
{
    static internal partial class Utility
    {
        static private int clickcount = 0;

        public static void CountClicked()
        {
            clickcount++;
        }

        public static int TimesClicked() 
        {
            return clickcount; 
        }

    }
}
