using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        private MenuItem m_Current;
        private MenuItem m_Previous;
        private MenuItem m_Next;
        private string m_Name;
        private byte m_Index;

        public MenuItem Current
        {
            get => m_Current;
            set => m_Current = value;
        }

        public MenuItem Previous
        {
            get => m_Previous;
            set => m_Previous = value;
        }

        public MenuItem Next
        {
            get => m_Next;
            set => m_Next = value;
        }

        public string Name
        {
            get => m_Name;
            set => m_Name = value;
        }

        public byte Index
        {
            get => m_Index;
            set => m_Index = value;
        }

        public MenuItem()
        {
            this.Current = this;
        }
    }
}
