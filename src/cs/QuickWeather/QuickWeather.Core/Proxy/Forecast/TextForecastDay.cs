using System.Runtime.Serialization;

namespace QuickWeather.Core.Proxy.Forecast
{
    public class TextForecastDay
    {
        public uint Period { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public string FctTextMetric { get; set; }
    }
}