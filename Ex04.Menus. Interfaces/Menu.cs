using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        #region Members
        private List<MainMenu> m_Menus;
        private List<MenuItem> m_MenuItems;
        private String m_MenuTitle;
        byte m_MenuIndex;
        #endregion

        #region Properties
        public List<MainMenu> Menus
        {
            get => m_Menus;
        }

        public List<MenuItem> MenuItems
        {
            get => m_MenuItems;
        }

        public String MenuTitle
        {
            get => m_MenuTitle;
            set => m_MenuTitle = value;
        }
        #endregion

        public MainMenu()
        {

        }

        #region Methods
        public void GoToPreviousMenu()
        {

        }

        public void ExitMenu()
        {
            Environment.Exit(0);
        }

        public MenuItem SelectItem(byte optionNumber)
        {
            return m_MenuItems[optionNumber - 1];
        } 

        public void AddMenu(MainMenu menu)
        {
            m_Menus.Add(menu);
        }

        public void AddMenuItem(MenuItem item)
        {
            m_MenuItems.Add(item);
        }

        public void RemoveMenuItem(MenuItem item)
        {
            m_MenuItems.Remove(item);
        }
        #endregion
    }
}
