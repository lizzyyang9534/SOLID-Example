using ArtExhibition.Interfaces;
using ArtExhibition.Models;

namespace ArtExhibition
{
    public class WatercolorToolBox : IWatercolorToolBox
    {
        public int[] GetPaper(int height, int width)
        {
            int[] paper = { height, width };
            return paper;
        }

        public Palette GetWatercolorPalette()
        {
            var palette = new Palette();
            return palette;
        }

        public string GetWaterColor(string color)
        {
            return color;
        }

        public WatercolorBrush GetPaintingBrush(string type)
        {
            var paintingPen = new WatercolorBrush() { Type = type };
            return paintingPen;
        }
    }
}
