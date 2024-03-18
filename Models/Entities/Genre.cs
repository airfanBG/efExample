using Models.Contracts;

namespace Models.Entities;

public class Genre:BaseEntity
{
    public string GenreType { get; set; }
    public IList<GenreSongs> GenreSongs { get; set; }
}