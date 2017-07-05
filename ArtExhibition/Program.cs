using System;

namespace ArtExhibition
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var leonardoDaVinci = new LeonardoDaVinci(ToolBoxFactory.GetOilPaintingToolBox());
            var monaLisa = leonardoDaVinci.DrawMonaLisa();
            var alberchtDurer = new AlbrechtDurer(ToolBoxFactory.GetWatercolorToolBox());
            var aYoungHare = alberchtDurer.DrawAYoungHare();

            var guide = new Guide();
            guide.ProvideInformation(monaLisa);
            guide.ProvidePaintingProcess(leonardoDaVinci.ProvidePaintingStepToGuide());
            Console.WriteLine("---------------------------------------------------");
            alberchtDurer.ProvidePaintingInformation(aYoungHare);
            alberchtDurer.ProvidePaintingProcess();
        }
    }
}
