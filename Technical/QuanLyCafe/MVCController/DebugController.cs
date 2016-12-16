using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace WinFormMVC.Controller
{
    public class DebugController
    {
        public IDebug m_debugView;
        public DebugController(IDebug _debugView)
        {
            this.m_debugView = _debugView;
        }
        public void ShowLog(string _messenger)
        {
            m_debugView.m_content = _messenger;
            m_debugView.ShowForm();
        }
    }
}
