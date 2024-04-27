using Aspnet_4_lab.Model.Models;
using ASPnet_4_lab.Repository.Abstract;

namespace ASPnet_4_lab.Repository.Repositories
{
    public class BookRepository : IBookRepository
    {
        private List<Book> _books;

        public BookRepository()
        {
            _books = new List<Book>();
        }

        public void AddBook(Book book) => _books.Add(book);

        public void Clear() => _books.Clear();

        public void DeleteBook(Book book) => _books.Remove(book);

        public List<Book> GetBooks() => _books;
    }
}
