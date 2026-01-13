using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SingleAmedasViewer
{
    public class DataClass
    {


        public class Data
        {
            [JsonPropertyName("prefNumber")]
            public int? PrefNumber { get; set; }

            [JsonPropertyName("observationNumber")]
            public int? ObservationNumber { get; set; }

            [JsonPropertyName("pressure")]
            public double?[]? Pressure { get; set; }

            [JsonPropertyName("normalPressure")]
            public double?[]? NormalPressure { get; set; }

            [JsonPropertyName("temp")]
            public double?[]? Temp { get; set; }

            [JsonPropertyName("humidity")]
            public int?[]? Humidity { get; set; }

            [JsonPropertyName("visibility")]
            public double?[]? Visibility { get; set; }

            [JsonPropertyName("snow")]
            public int?[]? Snow { get; set; }

            [JsonPropertyName("weather")]
            public int?[]? Weather { get; set; }

            [JsonPropertyName("snow1h")]
            public int?[]? Snow1h { get; set; }

            [JsonPropertyName("snow6h")]
            public int?[]? Snow6h { get; set; }

            [JsonPropertyName("snow12h")]
            public int?[]? Snow12h { get; set; }

            [JsonPropertyName("snow24h")]
            public int?[]? Snow24h { get; set; }

            [JsonPropertyName("sun10m")]
            public int?[]? Sun10m { get; set; }

            [JsonPropertyName("sun1h")]
            public double?[]? Sun1h { get; set; }

            [JsonPropertyName("precipitation10m")]
            public double?[]? Precipitation10m { get; set; }

            [JsonPropertyName("precipitation1h")]
            public double?[]? Precipitation1h { get; set; }

            [JsonPropertyName("precipitation3h")]
            public double?[]? Precipitation3h { get; set; }

            [JsonPropertyName("precipitation24h")]
            public double?[]? Precipitation24h { get; set; }

            [JsonPropertyName("windDirection")]
            public int?[]? WindDirection { get; set; }

            [JsonPropertyName("wind")]
            public double?[]? Wind { get; set; }

            [JsonPropertyName("maxTempTime")]
            public C_Time? MaxTempTime { get; set; }

            [JsonPropertyName("maxTemp")]
            public double?[]? MaxTemp { get; set; }

            [JsonPropertyName("minTempTime")]
            public C_Time? MinTempTime { get; set; }

            [JsonPropertyName("minTemp")]
            public double?[]? MinTemp { get; set; }

            [JsonPropertyName("gustTime")]
            public C_Time? GustTime { get; set; }

            [JsonPropertyName("gustDirection")]
            public int?[]? GustDirection { get; set; }

            [JsonPropertyName("gust")]
            public double?[]? Gust { get; set; }

            public class C_Time
            {
                [JsonPropertyName("hour")]
                public int? Hour { get; set; }

                [JsonPropertyName("minute")]
                public int? Minute { get; set; }
            }
        }


        public class ObsPoint
        {
            [JsonPropertyName("type")]
            public required string Type { get; set; }

            [JsonPropertyName("elems")]
            public required string Elems { get; set; }

            [JsonPropertyName("lat")]
            public required List<double> Lat { get; set; }

            [JsonPropertyName("lon")]
            public required List<double> Lon { get; set; }

            [JsonPropertyName("alt")]
            public required int Alt { get; set; }

            [JsonPropertyName("kjName")]
            public required string KjName { get; set; }

            [JsonPropertyName("knName")]
            public required string KnName { get; set; }

            [JsonPropertyName("enName")]
            public required string EnName { get; set; }
        }

        public static string DateTime2ThreeHourString(DateTime dt) => new DateTime(dt.Year, dt.Month, dt.Day, (dt.Hour / 3) * 3, 0, 0).ToString("yyyyMMdd_HH");



        public static string Code2RegionName(int code) => code switch
        {
            11 => "宗谷総合振興局",
            12 => "上川総合振興局",
            13 => "留萌振興局",
            14 => "石狩振興局",
            15 => "空知総合振興局",
            16 => "後志総合振興局",
            17 => "オホーツク総合振興局",
            18 => "根室振興局",
            19 => "釧路総合振興局",
            20 => "十勝総合振興局",
            21 => "胆振総合振興局",
            22 => "日高振興局",
            23 => "渡島総合振興局",
            24 => "檜山振興局",
            31 => "青森県",
            32 => "秋田県",
            33 => "岩手県",
            34 => "宮城県",
            35 => "山形県",
            36 => "福島県",
            40 => "茨城県",
            41 => "栃木県",
            42 => "群馬県",
            43 => "埼玉県",
            44 => "東京都",
            45 => "千葉県",
            46 => "神奈川県",
            48 => "長野県",
            49 => "山梨県",
            50 => "静岡県",
            51 => "愛知県",
            52 => "岐阜県",
            53 => "三重県",
            54 => "新潟県",
            55 => "富山県",
            56 => "石川県",
            57 => "福井県",
            60 => "滋賀県",
            61 => "京都府",
            62 => "大阪府",
            63 => "兵庫県",
            64 => "奈良県",
            65 => "和歌山県",
            66 => "岡山県",
            67 => "広島県",
            68 => "島根県",
            69 => "鳥取県",
            71 => "徳島県",
            72 => "香川県",
            73 => "愛媛県",
            74 => "高知県",
            81 => "山口県",
            82 => "福岡県",
            83 => "大分県",
            84 => "長崎県",
            85 => "佐賀県",
            86 => "熊本県",
            87 => "宮崎県",
            88 => "鹿児島県",
            91 => "沖縄県（本島など）",//沖縄県（下記の地域を除く）
            92 => "南大東村・北大東村",//島尻郡のうち 南大東村・北大東村
            93 => "宮古島市及び宮古郡",
            94 => "石垣市及び八重山郡",
            _ => "不明な番号",
        };


        public static string WeatherInt2String(int? num) => num switch
        {
            0 => "晴れ",
            1 => "くもり",
            2 => "煙霧",
            3 => "霧",
            4 => "降水",
            5 => "霧雨",
            6 => "着氷性の霧雨",
            7 => "雨",
            8 => "着氷性の雨",
            9 => "みぞれ",
            10 => "雪",
            11 => "凍雨",
            12 => "霧雪",
            13 => "しゅう雨",//または止み間のある雨
            14 => "しゅう雪",//または止み間のある雪
            15 => "ひょう",
            16 => "雷",
            _ => "(未実装)"
        };


        public static string ObsCode2Name(string code) => code switch
        {
            "A" => "気象台",
            "B" => "測候所・特別地域気象観測所",
            "C" => "地域気象観測所（アメダス）",
            "D" => "富士山特別地域気象観測所",
            "E" => "南鳥島気象観測所",
            "F" => "富士山特別地域気象観測所",
            "G" => "その他の気象観測所",
            _ => "（未実装）",
        };

        public static string WindDireInt2String(int? num) => num switch
        {
            0 => "静穏",
            1 => "北北東",
            2 => "北東",
            3 => "東北東",
            4 => "東",
            5 => "東南東",
            6 => "南東",
            7 => "南南東",
            8 => "南",
            9 => "南南西",
            10 => "南西",
            11 => "西南西",
            12 => "西",
            13 => "西北西",
            14 => "北西",
            15 => "北北西",
            16 => "北",
            _ => "（未実装）",
        };

        public static int? Hour2JstHour(int? hourUtc)
        {
            if (hourUtc == null)
                return null;
            int hourJst = (int)hourUtc + 9;
            if (hourJst >= 24)
                hourJst -= 24;
            return hourJst;
        }
    }

}
