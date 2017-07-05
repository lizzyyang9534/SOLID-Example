using System;
using System.Collections.Generic;
using System.Linq;
using ArtExhibition.Models;

namespace ArtExhibition
{
    public class Guide
    {
        public void ProvideInformation(Painting painting)
        {
            Console.WriteLine("Painting Name: " + painting.Name);
            Console.WriteLine("Artist Name: " + painting.Artist);
            Console.WriteLine("Year: " + painting.Year);
        }

        public void ProvidePaintingProcess(List<PaintingStep> paintingSteps)
        {
            Console.WriteLine("Painting Process:");
            foreach (var paintingStep in paintingSteps)
            {
                Console.WriteLine("    Painting Part: " + paintingStep.PaintingPart);
                Console.WriteLine("    Painting Pen: " + paintingStep.PaintingPen);
                Console.WriteLine("    Color: " + paintingStep.Color);
                if (paintingStep != paintingSteps.Last())
                    Console.WriteLine("        ↓");
            }
        }
    }
}
