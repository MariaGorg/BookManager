using System.ComponentModel.DataAnnotations;

namespace BookManager.Models.ViewModels
{
    public class AiRecommendationsViewModel
    {
        [Required(ErrorMessage = "Въведете интересите си.")]
        [StringLength(500)]
        public string Interests { get; set; } = "";

        public List<AiBookRecommendation> Recommendations
        { get; set; } = new();

        public string? ErrorMessage { get; set; }
        public string Provider { get; set; } = "OpenAI";
    }
}