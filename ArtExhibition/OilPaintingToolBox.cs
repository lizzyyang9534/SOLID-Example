using ArtExhibition.Interfaces;
using ArtExhibition.Models;

namespace ArtExhibition
{
    public class OilPaintingToolBox : IOilPaintingToolBox
    {
        public int[] GetPanel(int height, int width)
        {
            int[] panel = {height, width};
            return panel;
        }

        public Palette GetOilPaintingPalette()
        {
            var palette = new Palette();
            return palette;
        }

        public string GetOilColor(string color)
        {
            return color;
        }

        public OilPaintingBrush GetPaintingBrush(string type)
        {
            var paintingPen = new OilPaintingBrush() {Type = type};
            return paintingPen;
        }
    }
}
