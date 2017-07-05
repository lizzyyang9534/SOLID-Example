using ArtExhibition.Models;

namespace ArtExhibition.Interfaces
{
    public interface IPainter
    {
        void PrepareWatercolorPaper(int height, int width); //ISP
        void PreparePaintingPanel(int height, int width);
        void PreparePalette();
        void PrepareAndDraw(PaintingStep paintingStep);
        void AddColorToPalette(string color);
        string TakePaintingPen(string paintingPenType);
        void Draw(PaintingStep paintingStep);
        void ProvidePaintingInformation(Painting painting);
    }
}
