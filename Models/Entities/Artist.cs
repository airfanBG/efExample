using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Contracts;

namespace Models.Entities;

public class Artist:BaseEntity
{
    [MaxLength(20)]
    public string Name { get; set; }
    public IList<ArtistSongs> ArtistSongs { get; set; }
}