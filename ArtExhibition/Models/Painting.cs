using System.Collections.Generic;

namespace ArtExhibition.Models
{
    public class Painting
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public int Year { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string Location { get; set; }
        public List<string> ColorsUsed { get; set; }
    }
}
