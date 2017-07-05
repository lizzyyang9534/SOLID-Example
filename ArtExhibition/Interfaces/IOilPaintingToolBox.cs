using ArtExhibition.Models;

namespace ArtExhibition.Interfaces
{
    public interface IOilPaintingToolBox
    {
        int[] GetPanel(int height, int width);
        Palette GetOilPaintingPalette();
        string GetOilColor(string color);
        OilPaintingBrush GetPaintingBrush(string type);
    }
}
