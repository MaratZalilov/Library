using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debil
{
    internal class Author
    {
        private string[] _name = new string[5] {"Petya","Tolya","Katya","Dima","Alex"} ;


        public void GetInfo()
        {
            foreach (string name in _name)
            {
                Console.WriteLine($"Автор книги {name}");
            }
        }
    }
}
