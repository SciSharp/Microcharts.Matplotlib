using System;
using Microcharts;

namespace Microcharts.Extensions
{
    public static class Microcharts
    {
        public static BarChart CreateBarChart(Entry[] entries)
        {
            return new BarChart { Entries = entries };      
        }
    }
}
