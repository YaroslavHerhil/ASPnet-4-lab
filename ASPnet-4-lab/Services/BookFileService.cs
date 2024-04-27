using Aspnet_4_lab.Model.Models;
using ASPnet_4_lab.Abstract;
using ASPnet_4_lab.Repository.Abstract;
using ASPnet_4_lab.Repository.Repositories;
using System.Diagnostics;

namespace ASPnet_4_lab.Services
{
    public class BookFileService : IBookService
    {

        List<Book> _books;
        string _path;
        public BookFileService() 
        {
            _books = new List<Book>();
            _path = "books.txt";
            if (!File.Exists(_path))
            {
                using (StreamWriter sw = File.CreateText(_path));
            }
            else
            {
                ReadBooksFromFile(_path);
            }
        }

        public BookFileService(string path)
        {
            _books = new List<Book>();
            path = "books.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path)) ;
            }
            else
            {
                ReadBooksFromFile(path);
            }
        }




        public void ReadBooksFromFile(string path)
        {
            _books.Clear();
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {

                    try
                    {
                        Book newBook = new Book();
                        newBook.AuthorName = ReadUntil(sr, "/");
                        newBook.Title = ReadUntil(sr, "/");
                        newBook.Genre = ReadUntil(sr, "/");
                        newBook.Setting = ReadUntil(sr, "/");
                        newBook.Publisher = ReadUntil(sr, "/");
                        newBook.ReleaseYear = int.Parse(ReadUntil(sr, "/"));
                        _books.Add(newBook);
                    }
                    catch (Exception ex) {Debug.WriteLine(ex.Message); }


                }
            }
        }
        public void WriteBookToFile(string path, Book book)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.Write(book);
            }
        }
        private string ReadUntil(StreamReader sr, string separator)
        {
            string output = "";
            while (sr.Peek() >= 0)
            {
                string nextSymbol = ((char)sr.Read()).ToString();
                if (nextSymbol == separator)
                {
                    break;
                }
                output += nextSymbol;
            }
            return output;
        }
        public void AddBook(Book book) => WriteBookToFile(_path, book);

        public Book GetBookByTitle(string title) => _books.FirstOrDefault(b => b.Title == title);

        public List<Book> GetBooks() => _books;
        public void RemoveBook(Book book) => _books.Remove(book);
       }
}
