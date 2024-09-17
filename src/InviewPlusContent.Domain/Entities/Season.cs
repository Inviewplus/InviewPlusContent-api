namespace InviewPlusContent.Domain.Entities;

public class Season
{
    public int Id { get; set; }
    public int SeasonNumber { get; set; }
    public int EpisodeCount { get; set; }
    public DateTime ReleaseDate { get; set; }
    public List<Episode> Episodes { get; set; } = new List<Episode>();

}