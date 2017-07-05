using ArtExhibition.Models;

namespace ArtExhibition.Interfaces
{
    public interface IWatercolorToolBox
    {
        int[] GetPaper(int height, int width);
        Palette GetWatercolorPalette();
        string GetWaterColor(string color);
        WatercolorBrush GetPaintingBrush(string type);
    }
}
