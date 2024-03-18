using Models.Contracts;

namespace Models.Entities;

public class GenreSongs:BaseEntity
{
    public string GenreId { get; set; }
    public Genre Genre { get; set; }
    public string SongId { get; set; }
    public Song Song { get; set; }
}