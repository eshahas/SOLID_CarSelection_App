using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SOLID_CarSelection_App.Business
{
    public abstract class iCustomer {

        string FName;
        string DoB;
        string Address;
        string Country;
        string Password;

        public bool VerifyPassword()
        {
            MessageBox.Show("VerifyPassword");
            return true;
        }

        public abstract void Login();
        public abstract void Register();
    }

    public class RegCustomer : iCustomer
    {
        public  override void Login()
        {
            MessageBox.Show("Login");
        }
        public override void Register()
        {
            //            MessageBox.Show("Register");
        }
    }
    public class newCustomer : iCustomer
    {
        public override void Login()
        {
            //            MessageBox.Show("Login");
        }
        public override void Register()
        {
            MessageBox.Show("Register");
        }

    }

    /*



       interface iCustomer

        {
            public void Login();
            public void Register();
            public bool VerifyPassword();
        }

        public class RegCustomer : iCustomer
        {
            public void Login()
            {
                Console.WriteLine("Login");
            }
            public void Register()
            {
    //            Console.WriteLine("Register");
            }
            public bool VerifyPassword()
            {
                Console.WriteLine("VerifyPassword");
                return true;
            }
        }
        public class newCustomer : iCustomer
        {
            public void Login()
            {
    //            Console.WriteLine("Login");
            }
            public void Register()
            {
                Console.WriteLine("Register");
            }
            public bool VerifyPassword()
            {
                Console.WriteLine("VerifyPassword");
                return true;
            }
        }
    */
}
