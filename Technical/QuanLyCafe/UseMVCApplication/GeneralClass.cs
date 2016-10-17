using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public class GeneralClass
{
    public static void ShowDialogError(string _messenger)
    {
        MessageBox.Show(_messenger, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
