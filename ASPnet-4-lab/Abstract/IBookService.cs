using Aspnet_4_lab.Model.Models;

namespace ASPnet_4_lab.Abstract
{
    public interface IBookService
    {
        public Book GetBookByTitle(string title);
        public List<Book> GetBooks();
        public void AddBook(Book book);
        public void RemoveBook(Book book);
    }
}
