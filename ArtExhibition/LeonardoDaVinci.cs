using System.Collections.Generic;
using ArtExhibition.Interfaces;
using ArtExhibition.Models;

namespace ArtExhibition
{
    public class LeonardoDaVinci : IOilPainter
    {
        private readonly IOilPaintingToolBox _OilPaintingToolbox;
        public int[] PaintingPanel;
        public Palette Palette;
        private readonly List<PaintingStep> _PaintingSteps;

        public LeonardoDaVinci(IOilPaintingToolBox oilPaintingToolbox)
        {
            _OilPaintingToolbox = oilPaintingToolbox; //DIP
            _PaintingSteps = new List<PaintingStep>();
        }

        public Painting DrawMonaLisa()
        {
            var monaLisa = new Painting
            {
                Name = "Mona Lisa",
                Artist = "Leonardo Da Vinci",
                Year = 1503
            };
            PreparePalette();
            PreparePaintingPanel(77, 53);
            DrawBackground();
            DrawSkin();
            DrawHair();
            DrawClothing();
            return monaLisa;
        }

        public void PreparePaintingPanel(int height, int width)
        {
            PaintingPanel = _OilPaintingToolbox.GetPanel(height, width);
        }
        
        public void PreparePalette()
        {
            Palette = _OilPaintingToolbox.GetOilPaintingPalette();
        }

        private void DrawBackground()
        {
            var color = new OilColor { Brand = "Winsor-Newton", ColorName = "Grass Green" };
            var backgroud = new PaintingStep
            {
                PaintingPart = "Background",
                PaintingPen = "Flat",
                Color = color.GetColorNameFromLabel()
            };
            PrepareAndDraw(backgroud);
        }

        private void DrawSkin()
        {
            var color = new OilColor { Brand = "Winsor-Newton", ColorName = "Skin Color" };
            var skin = new PaintingStep
            {
                PaintingPart = "Skin",
                PaintingPen = "Round",
                Color = color.GetColorNameFromLabel()
            };
            PrepareAndDraw(skin);
        }

        private void DrawHair()
        {
            var color = new OilColor { Brand = "Holbein", ColorName = "Black" };
            var hair = new PaintingStep
            {
                PaintingPart = "Hair",
                PaintingPen = "Round",
                Color = color.GetColorNameFromLabel()
            };
            PrepareAndDraw(hair);
        }

        private void DrawClothing()
        {
            var color = new OilColor { Brand = "Holbein", ColorName = "Black" };
            var clothing = new PaintingStep
            {
                PaintingPart = "Clothing",
                PaintingPen = "Round",
                Color = color.GetColorNameFromLabel()
            };
            PrepareAndDraw(clothing);
        }

        public void PrepareAndDraw(PaintingStep paintingStep)
        {
            PickColorOnPalette(paintingStep.Color);
            TakePaintingPen(paintingStep.PaintingPen);
            Draw(paintingStep);
        }

        public string PickColorOnPalette(string color)
        {
            if (!Palette.Colors.Exists(x => x.Equals(color)))
                AddColorToPalette(color);
            return color;
        }

        public void AddColorToPalette(string color)
        {
            if (Palette.Colors.Contains(color))
                return;
            var colorToBeAdd = _OilPaintingToolbox.GetOilColor(color);
            Palette.Colors.Add(colorToBeAdd);
        }

        public string TakePaintingPen(string paintingPenType)
        {
            return _OilPaintingToolbox.GetPaintingBrush(paintingPenType).Type;
        }

        public void Draw(PaintingStep paintingStep)
        {
            _PaintingSteps.Add(paintingStep);
        }

        public List<PaintingStep> ProvidePaintingStepToGuide()
        {
            return _PaintingSteps;
        }
    }
}
