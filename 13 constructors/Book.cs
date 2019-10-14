using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_constructors
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle, string AAuthor, int aPages)
        {
            title = aTitle;
            author = AAuthor;
            pages = aPages;
        }
    }
}
