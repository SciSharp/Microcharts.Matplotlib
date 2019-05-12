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
    public class ChartBuilder<TChart> : IChartBuilder
        where TChart : Chart, new()
    {
        public static readonly SKColor[] DefinedColors =
		{
			SKColor.Parse("#266489"),
			SKColor.Parse("#68B9C0"),
			SKColor.Parse("#90D585"),
			SKColor.Parse("#F3C151"),
			SKColor.Parse("#F37F64"),
			SKColor.Parse("#424856"),
			SKColor.Parse("#8F97A4"),
			SKColor.Parse("#DAC096"),
			SKColor.Parse("#76846E"),
			SKColor.Parse("#DABFAF"),
			SKColor.Parse("#A65B69"),
			SKColor.Parse("#97A69D"),
		};

        public IList<int> Values { get; set; }

        public IList<string> Labels { get; set; }

        public IList<string> Colors { get; set; }

        public virtual Chart Build()
        {
            var labels = Labels;
            var values = Values;
            var colors = Colors;

            if (Labels.Count !=  Values.Count)
                throw new Exception($"{nameof(labels)} and {nameof(values)} have different length.");

            var entries = Enumerable.Range(0, labels.Count).Select(i =>
            {                
                var color = SKColor.Empty;

                if (colors == null || colors.Count <= 0 || !SKColor.TryParse(colors[i], out color))
                {
                    color = DefinedColors[i % DefinedColors.Length];
                }

                return new Entry(values[i])
                {
                    Label = labels[i],
                    Color = color,
                    ValueLabel = values[i].ToString()
                };
            });

            var chart = new TChart();
            chart.Entries = entries;
            return chart;
        }
    }
}
