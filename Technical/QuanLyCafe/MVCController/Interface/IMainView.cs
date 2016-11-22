using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinFormMVC.Model;

namespace WinFormMVC.Controller
{
    public interface IMainView
    {
        string m_statusLogin{get;set;}
        string m_welcome { get; set; }
        Admin m_currentAdmin { get; set; }
        void SetController(MainController _mainController);
    }
}
