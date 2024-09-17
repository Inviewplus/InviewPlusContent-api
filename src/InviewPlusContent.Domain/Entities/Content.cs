using InviewPlusContent.Domain.Enums;

namespace InviewPlusContent.Domain.Entities;


public class Content
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime ReleaseDate { get; set; }
    public ContentType Type { get; set; }
    public string Director { get; set; }
    public int? Duration { get; set; }    // Nullable, applicable for movies
    public List<Season> Seasons { get; set; } = new List<Season>(); // Only applicable for series
}
    