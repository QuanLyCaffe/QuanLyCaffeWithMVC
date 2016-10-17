using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormMVC.Model
{
    public class mAdmin
    {
        public enum isAdmin
        {
            Male = 1,
            Female = 2
        }

        private string m_adminName;
        private string m_password;
        private isAdmin m_admin;

        public string AdminName
        {
            get
            {
                return m_adminName;
            }

            set
            {
                if (value.Length >= 51)
                {
                    Console.WriteLine("Ten qua dai !");
                }
                else
                {
                    m_adminName = value;
                }            
            }
        }
        public string Password
        {
            get
            {
                return m_password;
            }

            set
            {
                if (value.Length > 20)
                {
                    Console.WriteLine("Password qua dai!");
                }
                else
                {
                    m_password = value;
                }
            }
        }
        public isAdmin Admin
        {
            get
            {
                return m_admin;
            }

            set
            {
                m_admin = value;
            }
        }
    }
}
