using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrayStorm
{
    class testClass
    {
        public int hi { get; set; }

        public bool booly { get; set; }

        public bool poo = true;

        public static int hiSTATIC = 64;

        public testClass()
        {
            Random rnd = new Random();
            this.hi = rnd.Next(1, 1000); // creates a number between 1 and 1000
            hiSTATIC = rnd.Next(1, 1000);
        }

        public testClass(int x, int y, bool trueOrFalse)
        {
            Random rnd = new Random();
            this.hi = rnd.Next(1, 1000); // creates a number between 1 and 1000
            hiSTATIC = rnd.Next(1, 1000);
            hiSTATIC += x += y; 
        }

        public void getValue()
        {
            System.Windows.Forms.MessageBox.Show(hiSTATIC.ToString("X"));
        }


    }
}
