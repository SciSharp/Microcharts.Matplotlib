using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microcharts;
using SkiaSharp;
using Newtonsoft.Json.Linq;

namespace Microcharts.Matplotlib
{
    public interface IChartBuilder
    {
        IList<int> Values { get; set; }

        IList<string> Labels { get; set; }

        IList<string> Colors { get; set; }
        
        Chart Build();
    }
}
