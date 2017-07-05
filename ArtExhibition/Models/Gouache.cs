using ArtExhibition.Interfaces;

namespace ArtExhibition.Models
{
    public class Gouache : IColor
    {
        public string Brand { get; set; }
        public string ColorName { get; set; }

        public string GetColorNameFromLabel() //LSP
        {
            return Brand + " - Gouache (" + ColorName + ")";
        }
    }
}
