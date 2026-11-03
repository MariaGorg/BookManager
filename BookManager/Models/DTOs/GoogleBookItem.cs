namespace BookManager.Models.DTOs
{
    public class GoogleBookItem
    {
        public string? Id { get; set; } //ново поле за съхранение на Google Book ID

        public GoogleVolumeInfo? VolumeInfo { get; set; }
    }
}
