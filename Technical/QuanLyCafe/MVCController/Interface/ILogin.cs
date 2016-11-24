using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormMVC.Controller
{
   public interface ILogin
    {
        string m_userName{get;set;}
        string m_passWord{get;set;}

        //void SetController(LoginController _loginController);
        bool Checking();
    }
}
