namespace InviewPlusContent.Domain.Entities;

public class Episode
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int EpisodeNumber { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int Duration { get; set; }
}