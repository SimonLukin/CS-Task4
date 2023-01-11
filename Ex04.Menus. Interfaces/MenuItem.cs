using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        private string m_Name;
        private byte m_Index;

        public string Name
        {
            get => m_Name;
            set => m_Name = value;
        }

        public byte Index
        {
            get => m_Index;
            set=> m_Index = value;
        }
    }
}
