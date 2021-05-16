using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LabMusic.Models
{
    public class LabMusicContext : DbContext
    {
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<ArtistsSongs> ArtistsSongs { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public LabMusicContext(DbContextOptions<LabMusicContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
