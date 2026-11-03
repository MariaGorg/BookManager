namespace BookManager.Models.ViewModels
{
    public class BookResult
    {
        public string GoogleBookId { get; set; } = "";

        public string Title { get; set; } = "";

        public string Authors { get; set; } = "";

        public string? PublishedYear { get; set; }

        public string? ThumbnailUrl { get; set; }

        public string? Description { get; set; }
    }
}
