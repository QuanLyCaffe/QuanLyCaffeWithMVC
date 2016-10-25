using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MVCController;
using MVCModal;

namespace WinFormMVC.Controller
{
    public class TableController
    {
        private Table m_SelectedTable;
        private ITableView m_View;
        private IList m_Tables;
        private Font m_FontTableBtn = new Font("Times New Roman", 13);
        private IList tables
        {
            get { return ArrayList.ReadOnly(m_Tables); }
        }

        public TableController(ITableView view, IList tables)
        {
            m_View = view;
            m_Tables = tables;
            view.SetController(this);
        }

        public bool IsBussyTable(Button btn)
        {
            foreach (Table table in m_Tables)
            {
                if (table.Id == btn.Tag.ToString() && table.IsBusy)
                {
                    return true;
                }
            }
            return false;
        }

        public void CreateButtonAddTable()
        {
            int m_IntTemp = 1;
            string m_StrTemp = "Bàn số " + m_IntTemp;
            while (m_IntTemp <= tables.Count && m_StrTemp == (tables[m_IntTemp - 1] as Table).Name)
            {
                m_IntTemp += 1;
                m_StrTemp = "Bàn số " + m_IntTemp;
            }
            var m_Table = new Table(m_StrTemp, m_IntTemp.ToString(), false);
            this.m_Tables.Add(m_Table);

            m_View.AddTableToFlowLayoutPanel(new Table(m_StrTemp, m_IntTemp.ToString(), false));
        }

        public void LoadTables()
        {
            m_View.ClearTables();
            foreach (Table table in m_Tables)
            {
                m_View.AddTableToFlowLayoutPanel(table);
            }
        }
    }
}
