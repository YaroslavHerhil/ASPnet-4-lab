using Aspnet_4_lab.Model.Models;
using ASPnet_4_lab.Abstract;
using ASPnet_4_lab.Repository;
using ASPnet_4_lab.Repository.Abstract;
using ASPnet_4_lab.Repository.Repositories;

namespace ASPnet_4_lab.Service
{
    public class BookRepoService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookRepoService()
        {
            _bookRepository = new BookRepository();
        }

        public BookRepoService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }


        public void AddBook(Book book) => _bookRepository.AddBook(book);

        public Book GetBookByTitle(string title) => _bookRepository.GetBooks().FirstOrDefault(b => b.Title == title);

        public List<Book> GetBooks() => _bookRepository.GetBooks();

        public void RemoveBook(Book book) => _bookRepository.DeleteBook(book);
        
    } 
}
