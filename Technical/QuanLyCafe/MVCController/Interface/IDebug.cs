using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormMVC.Controller
{
    public interface IDebug
    {
        string m_content { set; get; }
        void ShowForm();
        void SetController(DebugController _controller);
    }
}
