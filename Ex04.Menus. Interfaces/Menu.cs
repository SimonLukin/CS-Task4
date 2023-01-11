using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public abstract class Menu
    {
        #region Members      
        private List<SubMenu> m_SubMenus;
        private Menu m_Current;
        private Menu m_Next;
        private Menu m_Previous;
        private List<MenuItem> m_MenuItems;
        private String m_MenuTitle;
        private byte m_MenuIndex;
        #endregion

        #region Properties
        public List<SubMenu> SubMenus
        {
            get => m_SubMenus;
            set => m_SubMenus = value;
        }

        public Menu Current
        {
            get => m_Current;
            set => m_Current = value;
        }

        public Menu Next
        {
            get => m_Next;      
            set => m_Next = value; 
        }

        public Menu Previous
        {
            get => m_Previous;
            set => m_Previous = value;
        }

        public List<MenuItem> MenuItems
        {
            get => m_MenuItems;
            set => m_MenuItems = value;
        }

        public String MenuTitle
        {
            get => m_MenuTitle;   
            set=> m_MenuTitle = value;
        }

        public byte MenuIndex
        {
            get => m_MenuIndex;
            set => m_MenuIndex = value;
        }
        #endregion

        #region Methods
        public abstract void GoToPreviousMenu();

        public abstract void SelectOption(byte io_OptionNumber);

        public void GoToNextMenu()
        {
            if (m_Next != null)
            {
                m_Current = m_Next;
            }   
            DisplayMenuOnConsole();
        }
 
        public void ActOnSelectedItem(MenuItem i_SelectedItem)
        {

            if (i_SelectedItem.Next != null)
            {
                GoToNextMenu();
            }
            else
            {
                // Activate somthing
            }
        }
 
        public MenuItem SelectItem(byte optionNumber)
        {
            return m_MenuItems[optionNumber - 1];
        }

        public void AddMenu(SubMenu menu)
        {
            m_SubMenus.Add(menu);
            menu.Previous = this;
            menu.Next = null;
            if (SubMenus[0] != null)
            {
                this.Next = m_SubMenus[0];
            }
            else
            {
                // Exption
            }
        }

        public void RemoveMenu(SubMenu menu)
        {
            if (menu.Next == null)
            {
                menu.Previous = null;
                m_SubMenus.Remove(menu);
            }
            else
            {
                Console.WriteLine("You can't delete this menu becouse it contains other menus, plase delete them first"); // Exeption
            }
        }

        public void AddMenuItem(MenuItem item)
        {          
            m_MenuItems.Add(item);
        }

        public void RemoveMenuItem(MenuItem item)
        {
            m_MenuItems.Remove(item);
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.Append(MenuTitle);
            text.Append("");
            text.Append("-------------------------");
            text.Append("");
            foreach(MenuItem item in m_MenuItems)
            {
                text.Append(item.Index+1 + "->" + item.Name);
            }
            if (m_MenuIndex == 0)
            {
                text.Append("0 -> Exit");
            }
            else
            {
                text.Append("0 -> Back");
            }
            text.Append("");
            return text.ToString();
        }

        public void DisplayMenuOnConsole()
        {
            Console.WriteLine(ToString());
        }
        #endregion
    }
}
 