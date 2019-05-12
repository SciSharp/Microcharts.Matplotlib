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
    public static class ChartBuilderExtensions
    {
        public static IChartBuilder Label(this IChartBuilder builder, IList<string> labels)
        {
            builder.Labels = labels;
            return builder;
        }

        public static IChartBuilder Value(this IChartBuilder builder, IList<int> values)
        {
            builder.Values = values;
            return builder;
        }

        public static IChartBuilder Colors(this IChartBuilder builder, IList<string> colors)
        {
            builder.Colors = colors;
            return builder;
        }
    }
}
