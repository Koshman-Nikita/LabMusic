using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabMusic.Models
{
    public class ArtistsSongs
    {
        public int SongId { get; set; }
        public int ArtistId { get; set; }
        public int Id { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Song Song { get; set; }
    }
}
