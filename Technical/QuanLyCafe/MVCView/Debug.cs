using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormMVC.Controller;
namespace MVCView
{
    public partial class Debug : Form,IDebug
    {
        public DebugController m_debug;
        public Debug()
        {
            InitializeComponent();
        }

        public string m_content
        {
            get
            {
                return lb1.Text;
            }
            set
            {
                lb1.Text = value;
            }
        }

        public void SetController(DebugController _controller)
        {
            throw new NotImplementedException();
        }
        public void ShowForm()
        {
            this.Show();
        }
    }
}
