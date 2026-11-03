namespace BookManager.Models.ViewModels
{
    public class BookSearchViewModel
    {
        public string Query { get; set; } = "";

        public List<BookResult> Results { get; set; } = new();

        public string? ErrorMessage { get; set; }
    }
}
