using System.ComponentModel.DataAnnotations;

namespace BookManager.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public string ISSN { get; set; }
        public string Genre { get; set; }


        // Ново поле
        [MaxLength(100)]
        public string? GoogleBookId { get; set; }
    }
}
