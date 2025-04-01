using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Item
    {
        private string _name;
        public string Name => _name;

        private string _info;
        public string Info => _info;

        public Item(string name, string info)
        {
            _name = name;
            _info = info;
        }
    }
}
