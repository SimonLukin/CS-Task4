using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : Menu
    {
        #region Constructor
        public MainMenu() 
        {
            this.Current = this;
            this.MenuTitle = "Main Menu";
            this.MenuIndex = 0;
            this.Previous = null;
        }
        #endregion

        #region Methods
 
        public override byte SelectOption()
        {
            byte option = byte.Parse(Console.ReadLine());
            if (option == 0)
            {
                ExitMenu();
            }
            return option;           
        }

        public void ExitMenu()
        {
            Environment.Exit(0);
        }

        public void show() // Show the menu to the user
        {

        }
        #endregion
    }
}