using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : Menu
    {
        public MainMenu() 
        {
            this.Current = this;
            this.MenuTitle = "Main Menu";
            this.MenuIndex = 0;
            this.Previous = null;
        }
        public override void GoToPreviousMenu() // There is no previous menu to the main menu
        {
            ExitMenu();
        }

        public void ExitMenu()
        {
            Environment.Exit(0);
        }

        public void show()
        {

        }
    }
}