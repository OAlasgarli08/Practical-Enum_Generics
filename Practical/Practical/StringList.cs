using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    internal class StringList
    {
        
        private string[] _string;

        public StringList()
        {
            _string = new string[0];
        }

        public void Add(string item)
        {
            Array.Resize(ref _string, _string.Length + 1);
            _string[_string.Length - 1] = item;
        }

        public void GetAll()
        {
            foreach (var item in _string)
            {
                Console.WriteLine(item);
            }
        }
    }
    
}

