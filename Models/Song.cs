using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabMusic.Models
{
    public class Song
    {
        public Song()
        {
            ArtistsSongs = new List<ArtistsSongs>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public int CategoryId { get; set; }
        public int AlbumId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Album Album { get; set; }
        public virtual ICollection<ArtistsSongs> ArtistsSongs { get; set; }



    }
}
