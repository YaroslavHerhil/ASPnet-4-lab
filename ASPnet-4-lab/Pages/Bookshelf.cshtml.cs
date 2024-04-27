using Aspnet_4_lab.Model.Models;
using ASPnet_4_lab.Abstract;
using ASPnet_4_lab.Service;
using ASPnet_4_lab.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPnet_4_lab.Pages
{
    public class BookshelfModel : PageModel
    {
        public IBookService BookRepoService;
        public IBookService BookFileService;

        public override void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
            BookRepoService = new BookRepoService();
            BookFileService = new BookFileService();


            if (BookFileService.GetBooks().Count == 0)
            {
                BookFileService.AddBook(new Book("Sir Lawrance Hedgecliff", "Martyr of the Stray Dogs", "Mystery", "Victorian England", "Gloverb", 1978));
                BookFileService.AddBook(new Book("Bonney Betty Belle", "Close the Door on the Way Out", "Comedy", "Office", "Practicality", 2008));
                BookFileService.AddBook(new Book("Prosketti Marcippio", "Swords Crossed", "Romance", "Medieval Italy", "Practicality", 2005));
            }
        }
        public void OnGet()
        {
            
        }
    }
}
