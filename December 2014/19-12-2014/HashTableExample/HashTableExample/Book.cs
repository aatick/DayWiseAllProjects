using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExample
{
    class Book
    {
        private string isbn;
        private string author;
        private string title;

        public Book(string isbn, string author, string title)
        {
            this.isbn = isbn;
            this.title = title;
            this.author = author;
        }
        public string ISBN
        {
            get { return isbn; }
        }

        public string Author
        {
            get { return author; }
        }

        public string Title
        {
            get { return title; }
        }
        
    }
}
