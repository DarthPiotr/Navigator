using System;

using SkiaSharp;

namespace NavigatorV2
{
    class TouchManipulationInfo
    {
        public SKPoint PreviousPoint { set; get; }

        public SKPoint NewPoint { set; get; }
    }
}
