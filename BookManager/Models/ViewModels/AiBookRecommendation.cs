namespace BookManager.Models.ViewModels
{
    public class AiBookRecommendation
    {
        public string GoogleBookId { get; set; } = "";

        public string Title { get; set; } = "";

        public string Authors { get; set; } = "";

        public string? ThumbnailUrl { get; set; }

        public string Reason { get; set; } = "";
    }
}