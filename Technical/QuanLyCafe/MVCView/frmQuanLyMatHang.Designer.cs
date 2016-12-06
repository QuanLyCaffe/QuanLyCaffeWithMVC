namespace MVCView
{
    partial class frmQuanLyMatHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkbIsActiveItem = new System.Windows.Forms.CheckBox();
            this.tbNameItem = new System.Windows.Forms.TextBox();
            this.btnClearItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnSaveItem = new System.Windows.Forms.Button();
            this.btnCreateItem = new System.Windows.Forms.Button();
            this.tbDescriptionItem = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUnitItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPriceItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbIdItem = new System.Windows.Forms.Label();
            this.tbIdItem = new System.Windows.Forms.TextBox();
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIsActive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewItem = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkbIsActiveItem
            // 
            this.checkbIsActiveItem.AutoSize = true;
            this.checkbIsActiveItem.Location = new System.Drawing.Point(127, 151);
            this.checkbIsActiveItem.Name = "checkbIsActiveItem";
            this.checkbIsActiveItem.Size = new System.Drawing.Size(89, 21);
            this.checkbIsActiveItem.TabIndex = 15;
            this.checkbIsActiveItem.Text = "Kích hoạt";
            this.checkbIsActiveItem.UseVisualStyleBackColor = true;
            // 
            // tbNameItem
            // 
            this.tbNameItem.Location = new System.Drawing.Point(127, 70);
            this.tbNameItem.Name = "tbNameItem";
            this.tbNameItem.Size = new System.Drawing.Size(118, 22);
            this.tbNameItem.TabIndex = 1;
            // 
            // btnClearItem
            // 
            this.btnClearItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearItem.ForeColor = System.Drawing.Color.Black;
            this.btnClearItem.Location = new System.Drawing.Point(676, 89);
            this.btnClearItem.Name = "btnClearItem";
            this.btnClearItem.Size = new System.Drawing.Size(93, 48);
            this.btnClearItem.TabIndex = 14;
            this.btnClearItem.Text = "Làm Mới";
            this.btnClearItem.UseVisualStyleBackColor = true;
            this.btnClearItem.Click += new System.EventHandler(this.btnClearItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteItem.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteItem.Location = new System.Drawing.Point(557, 85);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(93, 48);
            this.btnDeleteItem.TabIndex = 13;
            this.btnDeleteItem.Text = "Xóa";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveItem.ForeColor = System.Drawing.Color.Black;
            this.btnSaveItem.Location = new System.Drawing.Point(676, 21);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.Size = new System.Drawing.Size(93, 48);
            this.btnSaveItem.TabIndex = 12;
            this.btnSaveItem.Text = "Lưu";
            this.btnSaveItem.UseVisualStyleBackColor = true;
            this.btnSaveItem.Click += new System.EventHandler(this.btnSaveItem_Click);
            // 
            // btnCreateItem
            // 
            this.btnCreateItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateItem.ForeColor = System.Drawing.Color.Black;
            this.btnCreateItem.Location = new System.Drawing.Point(557, 21);
            this.btnCreateItem.Name = "btnCreateItem";
            this.btnCreateItem.Size = new System.Drawing.Size(93, 48);
            this.btnCreateItem.TabIndex = 11;
            this.btnCreateItem.Text = "Thêm";
            this.btnCreateItem.UseVisualStyleBackColor = true;
            this.btnCreateItem.Click += new System.EventHandler(this.btnCreateItem_Click);
            // 
            // tbDescriptionItem
            // 
            this.tbDescriptionItem.Location = new System.Drawing.Point(281, 89);
            this.tbDescriptionItem.Name = "tbDescriptionItem";
            this.tbDescriptionItem.Size = new System.Drawing.Size(240, 83);
            this.tbDescriptionItem.TabIndex = 10;
            this.tbDescriptionItem.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thành phần chi tiết";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Đơn vị tính";
            // 
            // tbUnitItem
            // 
            this.tbUnitItem.Location = new System.Drawing.Point(359, 26);
            this.tbUnitItem.Name = "tbUnitItem";
            this.tbUnitItem.Size = new System.Drawing.Size(162, 22);
            this.tbUnitItem.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giá";
            // 
            // tbPriceItem
            // 
            this.tbPriceItem.Location = new System.Drawing.Point(127, 111);
            this.tbPriceItem.Name = "tbPriceItem";
            this.tbPriceItem.Size = new System.Drawing.Size(118, 22);
            this.tbPriceItem.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mặt hàng";
            // 
            // lbIdItem
            // 
            this.lbIdItem.AutoSize = true;
            this.lbIdItem.Location = new System.Drawing.Point(54, 26);
            this.lbIdItem.Name = "lbIdItem";
            this.lbIdItem.Size = new System.Drawing.Size(19, 17);
            this.lbIdItem.TabIndex = 1;
            this.lbIdItem.Text = "Id";
            // 
            // tbIdItem
            // 
            this.tbIdItem.Location = new System.Drawing.Point(127, 23);
            this.tbIdItem.Name = "tbIdItem";
            this.tbIdItem.Size = new System.Drawing.Size(118, 22);
            this.tbIdItem.TabIndex = 0;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Thành phân chi tiết";
            this.columnDescription.Width = 190;
            // 
            // columnIsActive
            // 
            this.columnIsActive.Text = "Kích hoạt";
            this.columnIsActive.Width = 120;
            // 
            // columnUnit
            // 
            this.columnUnit.Text = "Đơn vị tính";
            this.columnUnit.Width = 110;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Giá(vnđ)";
            this.columnPrice.Width = 130;
            // 
            // columnName
            // 
            this.columnName.Text = "Mặt hàng";
            this.columnName.Width = 120;
            // 
            // columnId
            // 
            this.columnId.Text = "Mã";
            // 
            // listViewItem
            // 
            this.listViewItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnName,
            this.columnPrice,
            this.columnUnit,
            this.columnIsActive,
            this.columnDescription});
            this.listViewItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewItem.ForeColor = System.Drawing.Color.Black;
            this.listViewItem.FullRowSelect = true;
            this.listViewItem.HideSelection = false;
            this.listViewItem.Location = new System.Drawing.Point(3, 3);
            this.listViewItem.Name = "listViewItem";
            this.listViewItem.Size = new System.Drawing.Size(906, 304);
            this.listViewItem.TabIndex = 0;
            this.listViewItem.UseCompatibleStateImageBehavior = false;
            this.listViewItem.View = System.Windows.Forms.View.Details;
            this.listViewItem.SelectedIndexChanged += new System.EventHandler(this.listViewItem_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.listViewItem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(912, 518);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.checkbIsActiveItem);
            this.panel5.Controls.Add(this.tbNameItem);
            this.panel5.Controls.Add(this.btnClearItem);
            this.panel5.Controls.Add(this.btnDeleteItem);
            this.panel5.Controls.Add(this.btnSaveItem);
            this.panel5.Controls.Add(this.btnCreateItem);
            this.panel5.Controls.Add(this.tbDescriptionItem);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.tbUnitItem);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.tbPriceItem);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.lbIdItem);
            this.panel5.Controls.Add(this.tbIdItem);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 313);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(906, 202);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(35, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(912, 518);
            this.panel4.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(35, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(912, 35);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(947, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 553);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(35, 553);
            this.panel1.TabIndex = 7;
            // 
            // frmQuanLyMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmQuanLyMatHang";
            this.Text = "frmQuanLyMatHang";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkbIsActiveItem;
        private System.Windows.Forms.TextBox tbNameItem;
        private System.Windows.Forms.Button btnClearItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnSaveItem;
        private System.Windows.Forms.Button btnCreateItem;
        private System.Windows.Forms.RichTextBox tbDescriptionItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUnitItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPriceItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIdItem;
        private System.Windows.Forms.TextBox tbIdItem;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.ColumnHeader columnIsActive;
        private System.Windows.Forms.ColumnHeader columnUnit;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ListView listViewItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}