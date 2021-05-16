using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabMusic.Models
{
    public class Album
    {
        public Album()
        {
            Songs = new List<Song>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
