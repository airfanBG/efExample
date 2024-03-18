using Models.Contracts;

namespace Models.Entities;

public class ArtistSongs:BaseEntity
{
    public string ArtistId { get; set; }
    public Artist Artist { get; set; }
    public string SongId { get; set; }
    public Song Song { get; set; }
}