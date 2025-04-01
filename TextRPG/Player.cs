using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Player
    {
        private int _power;
        public int Power { get { return _power; } set { _power = value; } }

        private int _speed;
        public int Speed { get { return _speed; } set { _speed = value; } }

        private List<Item> _inventory = new List<Item>();
        private int _gold;
        public int Gold { get { return _gold; } set { _gold = value;  } }

        public void AddItem(Item item)
        {
            _inventory.Add(item);
        }

        public void PrintItems()
        {
            foreach(Item item in _inventory)
            {
                Console.WriteLine($"이름 : {item.Name}");
                Console.WriteLine($"설명 : {item.Info}");
                Console.WriteLine();
            }
        }
    }
}
