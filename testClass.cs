using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GrayStorm
{
    class testClass
    {
        public bool returnStatement()
        {
            return false;
        }

        public void trueOrFalse()
        {
            int x;
            if (returnStatement())
                System.Windows.Forms.MessageBox.Show("True");
            else
                System.Windows.Forms.MessageBox.Show("False");
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




    
