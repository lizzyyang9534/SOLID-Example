using System.Collections.Generic;

namespace ArtExhibition.Models
{
    public class Palette
    {
        public string Material { get; set; }
        public List<string> Colors { get; set; }

        public Palette()
        {
            Colors = new List<string>();
        }
    }
}
