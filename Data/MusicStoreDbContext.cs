using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace Data;

public class MusicStoreDbContext:DbContext
{
    public DbSet<Artist> Artists { get; set; }
    public DbSet<ArtistSongs> ArtistSongs { get; set; }
    public DbSet<CommercialStuff> CommercialStuffs { get; set; }
    public DbSet<DiscountKey> DiscountKeys { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<GenreSongs> GenreSongs { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Song> Songs { get; set; }
    public DbSet<User> Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;username=postgres;password=postgres;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var users = new List<User>()
        {
            new User()
            {
                Username = "Pesho"
            },
            new User()
            {
                Username = "Gosho"
            }
        };
        var genres = new List<Genre>()
        {
            new Genre()
            {
                GenreType = "Pop"
            },
            new Genre()
            {
                GenreType = "Rock"
            }
        };
        var songs = new List<Song>()
        {
            new Song()
            {
                Duration = 1100,
                Title = "Hello",
                Image = "url",
                Year = 2000
            },
            new Song()
            {
                Duration = 3451,
                Title = "Test",
                Image = "url",
                Year = 2005
            }
        };
        var artists = new List<Artist>()
        {
            new Artist()
            {
                Name = "Iggy pop"
            },
            new Artist()
            {
                Name = "Pink floyd"
            }
        };
        var artistSongs = new List<ArtistSongs>()
        {
            new ArtistSongs()
            {
                ArtistId = artists[0].Id,
                SongId = songs[0].Id
            }
        };
        var genreSongs = new List<GenreSongs>()
        {
            new GenreSongs()
            {
                GenreId = genres[0].Id,
                SongId = songs[0].Id
            }
        };
        modelBuilder.Entity<User>().HasData(users);
        modelBuilder.Entity<Genre>().HasData(genres);
        modelBuilder.Entity<Song>().HasData(songs);
        modelBuilder.Entity<ArtistSongs>().HasData(artistSongs);
        modelBuilder.Entity<Artist>().HasData(artists);
        modelBuilder.Entity<GenreSongs>().HasData(genreSongs);
    }
}