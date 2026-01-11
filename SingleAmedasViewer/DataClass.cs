using System.Text.Json.Serialization;

namespace SingleAmedasViewer
{
    internal class DataClass
    {


        public class Data
        {
            [JsonPropertyName("prefNumber")]
            public required int PrefNumber { get; set; }

            [JsonPropertyName("observationNumber")]
            public required int ObservationNumber { get; set; }

            [JsonPropertyName("pressure")]
            public required double[] Pressure { get; set; }

            [JsonPropertyName("normalPressure")]
            public required double[] NormalPressure { get; set; }

            [JsonPropertyName("temp")]
            public required double[] Temp { get; set; }

            [JsonPropertyName("humidity")]
            public required int[] Humidity { get; set; }

            [JsonPropertyName("visibility")]
            public required int[] Visibility { get; set; }

            [JsonPropertyName("snow")]
            public required int[] Snow { get; set; }

            [JsonPropertyName("weather")]
            public required int[] Weather { get; set; }

            [JsonPropertyName("snow1h")]
            public required int[] Snow1h { get; set; }

            [JsonPropertyName("snow6h")]
            public required int[] Snow6h { get; set; }

            [JsonPropertyName("snow12h")]
            public required int[] Snow12h { get; set; }

            [JsonPropertyName("snow24h")]
            public required int[] Snow24h { get; set; }

            [JsonPropertyName("sun10m")]
            public required int[] Sun10m { get; set; }

            [JsonPropertyName("sun1h")]
            public required int[] Sun1h { get; set; }

            [JsonPropertyName("precipitation10m")]
            public required int[] Precipitation10m { get; set; }

            [JsonPropertyName("precipitation1h")]
            public required double[] Precipitation1h { get; set; }

            [JsonPropertyName("precipitation3h")]
            public required int[] Precipitation3h { get; set; }

            [JsonPropertyName("precipitation24h")]
            public required int[] Precipitation24h { get; set; }

            [JsonPropertyName("windDirection")]
            public required int[] WindDirection { get; set; }

            [JsonPropertyName("wind")]
            public required double[] Wind { get; set; }

            [JsonPropertyName("maxTempTime")]
            public required C_Time MaxTempTime { get; set; }

            [JsonPropertyName("maxTemp")]
            public required double[] MaxTemp { get; set; }

            [JsonPropertyName("minTempTime")]
            public required C_Time MinTempTime { get; set; }

            [JsonPropertyName("minTemp")]
            public required double[] MinTemp { get; set; }

            [JsonPropertyName("gustTime")]
            public required C_Time GustTime { get; set; }

            [JsonPropertyName("gustDirection")]
            public required int[] GustDirection { get; set; }

            [JsonPropertyName("gust")]
            public required double[] Gust { get; set; }

            public class C_Time
            {
                [JsonPropertyName("hour")]
                public required int Hour { get; set; }

                [JsonPropertyName("minute")]
                public required int Minute { get; set; }
            }
        }
    }
}