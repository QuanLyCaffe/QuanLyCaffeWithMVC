using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using MVCModal;
using WinFormMVC.Model;

namespace WinFormMVC.Controller
{
    public interface ITableView
    {
        void SetController(TableController controller);
        void AddTableToFlowLayoutPanel(Table table);
        void DeleteButton();
        void BtnTable_Click(object sender, EventArgs e);
        void ClearTables();

    }
}
