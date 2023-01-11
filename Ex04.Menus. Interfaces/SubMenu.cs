﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : Menu
    {
      
        public SubMenu() 
        {
            this.Current = this;           
        }
        public override void GoToPreviousMenu() 
        {
            if (this.Current != null)
            {
                this.Current = this.Previous;
            }
        }
    }
}