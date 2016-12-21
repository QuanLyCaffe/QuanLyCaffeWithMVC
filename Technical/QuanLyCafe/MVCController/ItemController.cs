using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MVCModal;

using WinFormMVC.Controller;
using WinFormMVC.Model;

namespace WinFormMVC.Controller
{
    public class ItemController
    {
        Item m_SelectedItem;
        IItem m_View;
        IList m_Items;

        public ItemController(IItem view, IList menus)
        {
            m_View = view;
            m_Items = menus;
            view.SetController(this);
        }

        public IList MMenus
        {
            get { return ArrayList.ReadOnly(m_Items); }
        }

        public void UpdateDetailValue(Item item)
        {
            m_View.Id = item.Id;
            m_View.NameMenu = item.Name;
            m_View.Prince = item.Price;
            m_View.Unit = item.Unit;
            m_View.Description = item.Description;
            m_View.IsActive = item.IsActive;
        }

        public void UpdateMenuWithViewValue(Item item)
        {
            item.Id = m_View.Id;
            item.Name = m_View.NameMenu;
            item.Price = m_View.Prince;
            item.Unit = m_View.Unit;
            item.Description = m_View.Description;
            item.IsActive = m_View.IsActive;
        }

        public void LoadView()
        {
            m_View.ClearListView();
            foreach (Item item in m_Items)
            {
                m_View.AddMenuToListView(item);
            }
            //m_View.SetSelectedMenu((item)m_Items[0]);
        }

        public void SelectedMenuChanged(string SelectedMenuId)
        {
            foreach (Item item in m_Items)
            {
                if (item.Id == SelectedMenuId)
                {
                    m_SelectedItem = item;
                    UpdateDetailValue(item);
                    m_View.SetSelectedMenu(item);
                    break;
                }
            }
        }

        public void AddNewMenu()
        {
            m_SelectedItem = new Item("", "", 0, "", "");
            UpdateDetailValue(m_SelectedItem);
        }

        public void Save()
        {
            UpdateMenuWithViewValue(m_SelectedItem);
            if (!m_Items.Contains(m_SelectedItem))
            {
                // add new item 
                this.m_Items.Add(m_SelectedItem);
                this.m_View.AddMenuToListView(m_SelectedItem);
            }
            else
            {
                //update existing
                this.m_View.UpdateListViewWithChangeMenu(m_SelectedItem);
            }
            m_View.SetSelectedMenu(m_SelectedItem);

        }

        public void Clear()
        {
            m_View.Id = "";
            m_View.NameMenu = "";
            m_View.IsActive = false;
            m_View.Unit = "";
            m_View.Description = "";
            m_View.Prince = 0;
        }

        public void Delete()
        {
            UpdateMenuWithViewValue(m_SelectedItem);
            MessageBox.Show("Bạn chắc chắn muốn xóa mặt hàng " + m_SelectedItem.Name + " có id là " + m_SelectedItem.Id, "Thông báo!", MessageBoxButtons.YesNo);
        }
    }
}
