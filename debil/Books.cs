using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debil
{
    internal class Books
    {
        private Author[] _authorName;
        private int _countPage;

        public Books()
        {
            Random random = new Random();
            _countPage = random.Next(20, 500);
        }

        public void GetInfo(Author author)
        {  
            author.GetInfo();
            Console.WriteLine($"Количество страниц {_countPage}");
        }
    }
}
