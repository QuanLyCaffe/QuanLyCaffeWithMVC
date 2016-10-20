using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormMVC.Model
{
    public class Admin
    {
        public Admin()
        {

        }
        public Admin(string _id, string _name,string _password,isAdmin _isAdmin)
        {
            this.m_id = _id;
            this.m_adminName = _name;
            this.m_password = _password;
            this.m_isAdmin = _isAdmin;
        }
        public enum isAdmin
        {
            Male = 1,
            Female = 2
        }

        private string m_id;

        public string Id
        {
            get { return m_id; }
            set { m_id = value; }
        }
        private string m_adminName;
        private string m_password;
        private isAdmin m_isAdmin;

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
        public isAdmin IsAdmin
        {
            get
            {
                return m_isAdmin;
            }

            set
            {
                m_isAdmin = value;
            }
        }
    }
}
