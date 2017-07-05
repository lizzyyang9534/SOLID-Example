using System.Collections.Generic;
using ArtExhibition.Models;

namespace ArtExhibition.Interfaces
{
    public interface IOilPainter
    {
        void PreparePaintingPanel(int height, int width);
        void PreparePalette();
        void PrepareAndDraw(PaintingStep paintingStep);
        string PickColorOnPalette(string color);
        void AddColorToPalette(string color);
        string TakePaintingPen(string paintingPenType);
        void Draw(PaintingStep paintingStep);
        List<PaintingStep> ProvidePaintingStepToGuide();
    }
}
