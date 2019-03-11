using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class MyLibrary
    {
        Dictionary<string, Book> books;

        public MyLibrary()
        {
            this.books = new Dictionary<string, Book>();
        }

        public bool AddBook(Book a)
        {
            if (this.books.ContainsKey(a.Title))
            return false;

            this.books.Add(a.Title, a);
            return true;
        }

        public bool RemoveBook(string title)
        {
            if (!this.books.ContainsKey(title))
            return false;

            this.books.Remove(title);
            return true;
        }

        public bool HaveThisBook(string title)
        {
            if (!this.books.ContainsKey(title))
            return false;

            return true;
        }

        public Book GetBook(string title)  // It is same idea as a "HaveThisBook"
        {
            if (!this.books.ContainsKey(title))
                return null;

                return this.books[title];
        }

        public Book GetBookByAuthor(string author)
        {
            foreach (KeyValuePair<string, Book> pair in this.books)
            {
                if (pair.Value.Author == author)
                return pair.Value;
            }
            return null;

        }

        public void Clear()
        {
            this.books.Clear();
        }

        public List<string> GetAuthors()
        {
            List<string> autors = new List<string>();
            foreach (Book book in this.books.Values)
            {
                autors.Add(book.Author);
            }

            return autors;
        }

        public List<Book> GetBooksSortedByAuthorName()
        {
            List<Book> books = new List<Book>();
            foreach (Book book in this.books.Values)
            {
                books.Add(book);
            }

            books.Sort();

            return books;
        }
        public List<string> GetBooksTitleSorted()
        {
            List<string> titles = new List<string>();
            foreach (Book book in this.books.Values)
            {
                titles.Add(book.Title);
            }

            titles.Sort();

            return titles;
        }

        public int Count
        {
            get
            {
                return this.books.Count;
            }
        }

        public override string ToString()
        {
            string list = $"My BD: {Count} books \n";

            foreach (KeyValuePair<string, Book> pair in books)
            {
                list += $"[Key (as a title of the book): {pair.Key}]\n{pair.Value}\n";
            }

            return list;
        }
    }
}
