using Models.Contracts;

namespace Models.Entities;

public class Song:BaseEntity
{
    public string Title { get; set; }
    public int Duration { get; set; }
    public int Year { get; set; }
    public string Image { get; set; }
    public IList<GenreSongs> GenreSongs { get; set; }
    public IList<ArtistSongs> ArtistSongs { get; set; }
   
}