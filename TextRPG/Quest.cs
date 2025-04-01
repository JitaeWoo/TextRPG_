using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Quest
    {
        private string _id;
        public string ID => _id;
        private string _info;
        public string Info => _info;

        public Quest(string id, string info)
        {
            _id = id;
            _info = info;
        }
    }
}
