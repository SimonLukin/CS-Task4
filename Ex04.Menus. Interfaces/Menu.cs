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
        public List<MainMenu> Menus
        {
            get => m_SubMenus;
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

        public void ActOnSelectedItem()
        {

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
            this.Next = menu;
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
            item.Previous = this.Previous.MenuItems[0].Current; 
        }

        public void RemoveMenuItem(MenuItem item)
        {
            m_MenuItems.Remove(item);
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.Append(m_MenuTitle);
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
            return text.ToString();
        }

        public void DisplayMenuOnConsole()
        {
            Console.WriteLine(ToString());
        }
        #endregion
    }
}
 