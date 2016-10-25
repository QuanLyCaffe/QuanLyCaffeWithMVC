using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MVCModal;
using WinFormMVC.Controller;

namespace MVCView
{
    public partial class frmQuanLyBan : Form, ITableView
    {
        private TableController m_Controller;
        private Font m_FontTableBtn = new Font("Times New Roman", 13);
        public frmQuanLyBan()
        {
            InitializeComponent();
        }

        public void SetController(TableController controller)
        {
            m_Controller = controller;
        }

        public void AddTableToFlowLayoutPanel(Table table)
        {
            Button btnTable = new Button();
            btnTable.ForeColor = Color.Black;
            btnTable.Name = table.Id;
            btnTable.Height = 100;
            btnTable.Width = 100;
            btnTable.Text = table.Name;
            btnTable.TextAlign = ContentAlignment.BottomCenter;
            btnTable.Font = m_FontTableBtn;
            btnTable.Click += BtnTable_Click;
            btnTable.Tag = table.Id;
            btnTable.ImageAlign = ContentAlignment.MiddleCenter;

            if (table.IsBusy)
            {
                btnTable.Image = ImageForTableButton(ImageTableButton.BusyButtonImage);
            }
            else
            {
                btnTable.Image = ImageForTableButton(ImageTableButton.DefaultButtonImage);
            }

            flpTables.Controls.Add(btnTable);
        }

        public void DeleteButton()
        {
            throw new NotImplementedException();
        }

        public void BtnTable_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)(sender);
            var controls = this.flpTables.Controls.OfType<Control>();

            //foreach table button in FlowLayoutPanel, change color for selected table button
            foreach (Button btn in controls)
            {
                //clear selected button
                if (!m_Controller.IsBussyTable(btn))
                {
                    btn.Image = ImageForTableButton(ImageTableButton.DefaultButtonImage);
                }
            }
            //hightlight selected button
            if (!m_Controller.IsBussyTable(clickedButton)) // clicked button is a empty table
            {
                clickedButton.Image = ImageForTableButton(ImageTableButton.SelectedButtonImage);
            }


            //update selected table to the detail view
            if (m_Controller.IsBussyTable(clickedButton)) // clicked button is a pussy table
            {
                SetControlsPussyTableForView();
                rbOderList.Text = clickedButton.Text + " đang có khách.";
            }
            else // this is a empty table
            {
                SetControlsEmptyTableForView();
                rbOderList.Text = clickedButton.Text + " đang trống.";
            }
                
        }

        public void ClearTables()
        {
            flpTables.Controls.Clear();

        }

        private void btnAddNewTable_Click(object sender, EventArgs e)
        {
            m_Controller.CreateButtonAddTable();
        }

        private enum ImageTableButton
        {
            DefaultButtonImage,
            SelectedButtonImage,
            BusyButtonImage,
        }

        private Bitmap ImageForTableButton(ImageTableButton image)
        {
            switch (image)
            {
                case ImageTableButton.DefaultButtonImage:
                    return MVCView.Properties.Resources.table_default;

                case ImageTableButton.SelectedButtonImage:
                    return MVCView.Properties.Resources.table_selected;

                case ImageTableButton.BusyButtonImage:
                    return MVCView.Properties.Resources.people;

                default:
                    return MVCView.Properties.Resources.table_default;
            }
        }

        private void SetControlsEmptyTableForView()
        {
            btnPayTable.Enabled = false;
            btnReaseTable.Enabled = false;
            btnEditTable.Enabled = true;
            btnDeleteTable.Enabled = true;
            btnEnterTable.Enabled = true;
            btnJoinTable.Enabled = false;
        }

        private void SetControlsPussyTableForView()
        {
            btnPayTable.Enabled = true;
            btnReaseTable.Enabled = true;
            btnEditTable.Enabled = false;
            btnDeleteTable.Enabled = false;
            btnEnterTable.Enabled = false;
            btnJoinTable.Enabled = true;

        }
    }
}
