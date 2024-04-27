using System.ComponentModel;

namespace Aspnet_4_lab.Model.Models
{
    public class Book
    {
        public string AuthorName {  get; set; }
        public string Title {  get; set; }
        public string Genre { get; set; }
        public string Setting{ get; set; }

        public string Publisher { get; set; }
        public int ReleaseYear { get; set; }

        public Book()
        {

        }

        public Book(string authorName, string title, string genre, string setting, string publisher, int releaseYear)
        {
            AuthorName = authorName;
            Title = title;
            Genre = genre;
            Setting = setting;
            Publisher = publisher;
            ReleaseYear = releaseYear;
        }

        public override string ToString() => $"{AuthorName}/{Title}/{Genre}/{Setting}/{Publisher}/{ReleaseYear}/";

    }
}
