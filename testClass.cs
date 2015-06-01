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

    class abc
    {
        //test function
        public bool validateLogin(string password, string savedPwd)
        {
            if (password == savedPwd)
            {
                return true;
            }
            else
                return false;
        }

        public static bool validateLoginSTATIC(string password, string savedPwd)
        {
            if (password == savedPwd)
            {
                return true;
            }
            else
                return false;
        }

        public static void loginStATIC()
        {
            if(validateLoginSTATIC("lol", "lol2"))
            {
                System.Windows.Forms.MessageBox.Show("Logged in");
            }
            else
                  System.Windows.Forms.MessageBox.Show("Failed");
        }

        public void login()
        {
            if (validateLogin("lol", "lol2"))
            {
                System.Windows.Forms.MessageBox.Show("Logged in");
            }
            else
                System.Windows.Forms.MessageBox.Show("Failed");

            System.Diagnostics.StackTrace stackTrace = new System.Diagnostics.StackTrace ();
            System.Windows.Forms.MessageBox.Show(stackTrace.ToString());
        }
    }
}




    
