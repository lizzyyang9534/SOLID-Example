using System;
using System.Collections.Generic;
using System.Linq;
using ArtExhibition.Interfaces;
using ArtExhibition.Models;

namespace ArtExhibition
{
    public class AlbrechtDurer : IWatercolorPainter
    {
        private readonly IWatercolorToolBox _WatercolorToolBox;
        public int[] PaintingPaper;
        public Palette Palette;
        private readonly List<PaintingStep> _PaintingSteps;

        public AlbrechtDurer(IWatercolorToolBox watercolorToolBox)
        {
            _WatercolorToolBox = watercolorToolBox;
            _PaintingSteps = new List<PaintingStep>();
        }

        public Painting DrawAYoungHare()
        {
            var aYoungHare = new Painting
            {
                Name = "A Young Hare",
                Artist = "Albrecht Durer",
                Year = 1502
            };
            PreparePalette();
            PrepareWatercolorPaper(25,22);
            DrawBody();
            DrawEyes();
            DrawPaws();
            DrawShadow();
            return aYoungHare;
        }

        public void PrepareWatercolorPaper(int height, int width)
        {
            PaintingPaper = _WatercolorToolBox.GetPaper(height, width);
        }

        public void PreparePalette()
        {
            Palette = _WatercolorToolBox.GetWatercolorPalette();
        }

        private void DrawBody()
        {
            var color = new Color { Brand = "Holbein", Type = "Gouache", ColorName = "Brown" };
            var body = new PaintingStep
            {
                PaintingPart = "Body",
                PaintingPen = "Round",
                Color = GetColorNameFromLabel(color)
            };
            PrepareToolsAndDraw(body);
        }

        public string GetColorNameFromLabel(Color color) //LSP
        {
            switch (color.Type)
            {
                case "Gouache":
                    return color.Brand + " - Gouache (" + color.ColorName + ")";
                case "Watercolor":
                    return color.Brand + " - Water Color (" + color.ColorName + ")";
                default:
                    return "No such color";
            }
        }

        private void DrawEyes()
        {
            var color = new Gouache { Brand = "Holbein", ColorName = "Black" }; //OCP
            var eyes = new PaintingStep
            {
                PaintingPart = "Eyes",
                PaintingPen = "Rigger",
                Color = color.GetColorNameFromLabel()
            };
            PrepareToolsAndDraw(eyes);
        }

        private void DrawPaws()
        {
            var color = new Gouache { Brand = "Holbein", ColorName = "Dark Brown" };
            var paws = new PaintingStep
            {
                PaintingPart = "Paws",
                PaintingPen = "Rigger",
                Color = color.GetColorNameFromLabel()
            };
            PrepareToolsAndDraw(paws);
        }

        private void DrawShadow()
        {
            var color = new Watercolor { Brand = "FABER-CASTELL", ColorName = "Dark Brown" };
            var shadow = new PaintingStep
            {
                PaintingPart = "Shadow",
                PaintingPen = "Round",
                Color = color.GetColorNameFromLabel()
            };
            PrepareToolsAndDraw(shadow);
        }

        public void PrepareToolsAndDraw(PaintingStep paintingStep)
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
            var colorToBeAdd = _WatercolorToolBox.GetWaterColor(color);
            Palette.Colors.Add(colorToBeAdd);
        }

        public string TakePaintingPen(string paintingPenType)
        {
            return _WatercolorToolBox.GetPaintingBrush(paintingPenType).Type;
        }

        public void Draw(PaintingStep paintingStep)
        {
            _PaintingSteps.Add(paintingStep);
        }

        public void ProvidePaintingInformation(Painting painting) //SRP
        {
            Console.WriteLine("Painting Name: " + painting.Name);
            Console.WriteLine("Artist Name: " + painting.Artist);
            Console.WriteLine("Year: " + painting.Year);
        }

        public void ProvidePaintingProcess()
        {
            Console.WriteLine("Painting Process:");
            foreach (var paintingStep in _PaintingSteps)
            {
                Console.WriteLine("    Painting Part: " + paintingStep.PaintingPart);
                Console.WriteLine("    Painting Pen: " + paintingStep.PaintingPen);
                Console.WriteLine("    Color: " + paintingStep.Color);
                if (paintingStep != _PaintingSteps.Last())
                    Console.WriteLine("        ↓");
            }
        }
    }
}
