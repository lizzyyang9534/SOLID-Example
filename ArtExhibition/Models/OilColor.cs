using ArtExhibition.Interfaces;

namespace ArtExhibition.Models
{
    public class OilColor : IColor
    {
        public string Brand { get; set; }
        public string ColorName { get; set; }

        public string GetColorNameFromLabel()
        {
            return Brand + " - Oil Color (" + ColorName + ")";
        }
    }
}
