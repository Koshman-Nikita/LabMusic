using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabMusic.Models
{
    public class Artist
    {
        public Artist()
        {
            ArtistsSongs = new List<ArtistsSongs>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public virtual ICollection<ArtistsSongs> ArtistsSongs { get; set; }
    }
}
