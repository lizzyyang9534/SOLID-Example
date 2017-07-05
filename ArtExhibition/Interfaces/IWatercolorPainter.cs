using ArtExhibition.Models;

namespace ArtExhibition.Interfaces
{
    public interface IWatercolorPainter
    {
        void PrepareWatercolorPaper(int height, int width);
        void PreparePalette();
        void PrepareToolsAndDraw(PaintingStep paintingStep);
        string PickColorOnPalette(string color);
        void AddColorToPalette(string color);
        string TakePaintingPen(string paintingPenType);
        void Draw(PaintingStep paintingStep);
        void ProvidePaintingProcess();
        void ProvidePaintingInformation(Painting painting);
    }
}
