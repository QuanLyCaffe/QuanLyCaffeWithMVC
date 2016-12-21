using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormMVC.Controller;
using WinFormMVC.Model;

namespace MVCView
{
    public partial class frmQuanLyMatHang : Form, IItem
    {
        private ItemController m_Controller;
        public frmQuanLyMatHang()
        {
            InitializeComponent();
        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            this.m_Controller.Save();
        }

        private void btnCreateItem_Click(object sender, EventArgs e)
        {
            m_Controller.AddNewMenu();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            this.m_Controller.Delete();
        }

        private void btnClearItem_Click(object sender, EventArgs e)
        {
            this.m_Controller.Clear();
        }

        private void listViewItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listViewItem.SelectedItems.Count > 0)
                this.m_Controller.SelectedMenuChanged(this.listViewItem.SelectedItems[0].Text);
        }

        public void SetController(ItemController controller)
        {
            this.m_Controller = controller;
        }

        public void ClearListView()
        {
            listViewItem.Items.Clear();
        }

        public void AddMenuToListView(Item item)
        {
            ListViewItem parrent;
            parrent = this.listViewItem.Items.Add(item.Id);
            parrent.SubItems.Add(item.Name);
            parrent.SubItems.Add((item.Price).ToString());
            parrent.SubItems.Add(item.Unit);
            if (item.IsActive)
            {
                parrent.SubItems.Add("Đã kích hoạt");
            }
            else
            {
                parrent.SubItems.Add("Chưa kích hoạt");
            }
            parrent.SubItems.Add(item.Description);
        }

        public void UpdateListViewWithChangeMenu(Item item)
        {
            ListViewItem rowToUpdate = null;
            foreach (ListViewItem row in this.listViewItem.Items)
            {
                if (row.Text == item.Id)
                {
                    rowToUpdate = row;
                }
            }
            if (rowToUpdate != null)
            {
                rowToUpdate.Text = item.Id;
                rowToUpdate.SubItems[1].Text = item.Name;
                rowToUpdate.SubItems[2].Text = item.Price.ToString();
                rowToUpdate.SubItems[3].Text = item.Unit;
                if (item.IsActive)
                {
                    rowToUpdate.SubItems[4].Text = "Đã kích hoạt";
                }
                else
                {
                    rowToUpdate.SubItems[4].Text = "Chưa kích hoạt";
                }
                rowToUpdate.SubItems[5].Text = item.Description;

            }
        }

        public void SetSelectedMenu(Item item)
        {
            tbDescriptionItem.Text = item.Description.ToString();
            tbIdItem.Text = item.Id;
            tbNameItem.Text = item.Name;
            tbPriceItem.Text = item.Price.ToString();
            tbUnitItem.Text = item.Unit;
        }

        public void RemoveItemFromListView(Item item)
        {
            ListViewItem rowToRemove = null;
            foreach (ListViewItem row in this.listViewItem.Items)
            {
                if (row.Text == item.Id)
                {
                    rowToRemove = row;
                }
                if (rowToRemove != null)
                {
                    this.listViewItem.Items.Remove(rowToRemove);
                    this.listViewItem.Focus();
                }
            }
        }

        public string Id
        {
            get { return this.tbIdItem.Text; }
            set { this.tbIdItem.Text = value; }
        }

        public string NameMenu
        {
            get { return this.tbNameItem.Text; }
            set { tbNameItem.Text = value; }
        }


        public double Prince
        {
            get { return Convert.ToDouble(this.tbPriceItem.Text); }
            set { this.tbPriceItem.Text = value.ToString(); }
        }

        public string Unit
        {
            get { return this.tbUnitItem.Text; }
            set { this.tbUnitItem.Text = value; }
        }

        public string Description
        {
            get { return this.tbDescriptionItem.Text; }
            set { this.tbDescriptionItem.Text = value; }
        }

        public bool IsActive
        {
            get
            {
                return this.checkbIsActiveItem.Checked;
            }
            set { this.checkbIsActiveItem.Checked = value; }
        }

     
    }
}
