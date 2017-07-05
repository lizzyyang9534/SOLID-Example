using ArtExhibition.Interfaces;

namespace ArtExhibition
{
    public class ToolBoxFactory
    {
        private static IOilPaintingToolBox _OilPaintingToolBox;
        private static IWatercolorToolBox _WatercolorToolBoxToolBox;

        public static IOilPaintingToolBox GetOilPaintingToolBox()
        {
            if (_OilPaintingToolBox == null)
                _OilPaintingToolBox = new OilPaintingToolBox();
            return _OilPaintingToolBox;
        }

        public static IWatercolorToolBox GetWatercolorToolBox()
        {
            if (_WatercolorToolBoxToolBox == null)
                _WatercolorToolBoxToolBox = new WatercolorToolBox();
            return _WatercolorToolBoxToolBox;
        }
    }
}
