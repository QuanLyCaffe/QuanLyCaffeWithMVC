using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WinFormMVC.Model;

namespace WinFormMVC.Controller
{
    public interface IItem
    {
        void SetController(ItemController controller);
        void ClearListView();
        void AddMenuToListView(Item item);
        void UpdateListViewWithChangeMenu(Item item);
        void SetSelectedMenu(Item item);
        void RemoveItemFromListView(Item item);
        string Id { get; set; }
        string NameMenu { get; set; }
        double Prince { get; set; }
        string Unit { get; set; }
        string Description { get; set; }
        bool IsActive { get; set; }
    }
}
