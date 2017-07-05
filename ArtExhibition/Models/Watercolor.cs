using ArtExhibition.Interfaces;

namespace ArtExhibition.Models
{
    public class Watercolor : IColor
    {
        public string Brand { get; set; }
        public string ColorName { get; set; }

        public string GetColorNameFromLabel()
        {
            return Brand + " - Water Color (" + ColorName + ")";
        }
    }
}
