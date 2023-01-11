using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : Menu
    {
        #region Constructor
        public SubMenu() 
        {
            this.Current = this;           
        }
        #endregion

        #region Methods
        public  void GoToPreviousMenu() 
        {
            if (this.Previous != null)
            {
                this.Current = this.Previous;
            }
            DisplayMenuOnConsole();
        }

        public override byte SelectOption()
        {
            byte option = byte.Parse(Console.ReadLine());
            if (option == 0)
            {
                GoToPreviousMenu();
            }
            return option;
        }
        #endregion
    }
}
