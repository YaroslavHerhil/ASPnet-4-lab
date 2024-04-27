using Aspnet_4_lab.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPnet_4_lab.Repository.Abstract
{
    public interface IBookRepository
    {
        public List<Book> GetBooks();
        public void AddBook(Book book);
        public void Clear();
        public void DeleteBook(Book book);
    }
}
