using System.Text.Json;
using static SingleAmedasViewer.DataClass;

namespace SingleAmedasViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            L_obsCode.Text = "";
            L_obsPref.Text = "";
            L_obsName.Text = "";
            L_obsNameKana.Text = "";
            L_obsInfo.Text = "";
            L_updateTime.Text = "";
            L_temp.Text = "";
            L_humid.Text = "";
            L_press.Text = "";
            L_pressKaimen.Text = "";
            L_rain10m.Text = "";
            L_rain1h.Text = "";
            L_rain3h.Text = "";
            L_rain24h.Text = "";
            L_windDire.Text = "";
            L_wind.Text = "";
            L_sun10m.Text = "";
            L_sun1h.Text = "";
            L_sitei.Text = "";
            L_h_snowH.Text = "";
            L_h_snow1h.Text = "";
            L_h_snow6h.Text = "";
            L_h_snow12h.Text = "";
            L_h_snow24h.Text = "";
            L_h_weather.Text = "";
            L_todayTemp.Text = "";
            L_todayTempTime.Text = "";
            L_todayWindDire.Text = "";
            L_todayWind.Text = "";
            L_todayWindTime.Text = "";

            var json_station_st = client.GetStringAsync("https://www.jma.go.jp/bosai/amedas/const/amedastable.json").Result;
            JSON_OBSPOINTS = JsonSerializer.Deserialize<Dictionary<string, ObsPoint>>(json_station_st)!;
        }

        public readonly Dictionary<string, ObsPoint> JSON_OBSPOINTS;
        internal int CODE = 56227;


        private void Form1_Load(object sender, EventArgs e)
        {
            GetAndView();
        }

        HttpClient client = new();

        internal async void GetAndView()
        {
            var obsData = JSON_OBSPOINTS[CODE.ToString()];
            L_obsCode.Text = CODE.ToString();
            L_obsPref.Text = Code2RegionName(CODE / 1000);
            L_obsName.Text = obsData.KjName;
            L_obsNameKana.Text = obsData.KnName + " / " + obsData.EnName;
            L_obsName.Location = new Point(L_obsPref.Width, 12);
            L_obsNameKana.Location = new Point(L_obsPref.Width + 5, 3);
            L_obsInfo.Text = "北緯" + obsData.Lat[0].ToString() + "度" + obsData.Lat[1].ToString("00.0") + "分, 東経" + obsData.Lon[0].ToString() + "度" + obsData.Lon[1].ToString("00.0") + "分\n種別: "
                + ObsCode2Name(obsData.Type) + "  標高" + obsData.Alt.ToString() + "m";
            //北緯 00度00.0分, 東経 000度00.0分
            //種別: 種別種・別種別種別種別種別(管)  標高 0000m

            var latestSt = await client.GetStringAsync("https://www.jma.go.jp/bosai/amedas/data/latest_time.txt");
            var latest = DateTime.Parse(latestSt);
            var amedasUrl = "https://www.jma.go.jp/bosai/amedas/data/point/" + CODE + "/" + DateTime2ThreeHourString(latest) + ".json";
            var jsonSt = await client.GetStringAsync(amedasUrl);
            var json = JsonSerializer.Deserialize<Dictionary<string, Data>>(jsonSt)!;
            var data = json[latest.ToString("yyyyMMddHHmmss")];
            var data2 = json[new DateTime(latest.Year, latest.Month, latest.Day, (latest.Hour / 3) * 3, 0, 0).ToString("yyyyMMddHHmmss")];

            L_updateTime.Text = latest.ToString("yyyy/MM/dd HH:mm");
            L_temp.Text = data.Temp?[0].ToString();
            L_humid.Text = data.Humidity?[0].ToString();
            L_press.Text = data.Pressure?[0].ToString();
            L_pressKaimen.Text = data.NormalPressure?[0].ToString();
            L_rain10m.Text = data.Precipitation10m?[0].ToString();
            L_rain1h.Text = data.Precipitation1h?[0].ToString();
            L_rain3h.Text = data.Precipitation3h?[0].ToString();
            L_rain24h.Text = data.Precipitation24h?[0].ToString();
            L_windDire.Text = WindDireInt2String(data.WindDirection?[0]);
            L_wind.Text = data.Wind?[0].ToString();
            L_sun10m.Text = data.Sun10m?[0].ToString();
            L_sun1h.Text = data.Sun1h?[0].ToString();
            L_sitei.Text = data.Visibility != null && data.Visibility.Length > 0 && data.Visibility[0] != 0
                ? (data.Visibility[0] / 1000.0).ToString("F2")
                : "";
            L_h_snowH.Text = data2.Snow?[0].ToString();
            L_h_snow1h.Text = data2.Snow1h?[0].ToString();
            L_h_snow6h.Text = data2.Snow6h?[0].ToString();
            L_h_snow12h.Text = data2.Snow12h?[0].ToString();
            L_h_snow24h.Text = data2.Snow24h?[0].ToString();
            L_h_weather.Text = WeatherInt2String(data2.Weather?[0]);
            L_todayTemp.Text = data.MaxTemp?[0].ToString() + "\n" + data.MinTemp?[0].ToString();
            L_todayTempTime.Text = "(" + Hour2JstHour(data.MaxTempTime?.Hour)?.ToString("D2") + ":" + data.MaxTempTime?.Minute?.ToString("D2") + ")\n("
                + Hour2JstHour(data.MinTempTime?.Hour)?.ToString("D2") + ":" + data.MinTempTime?.Minute?.ToString("D2") + ")";
            L_todayWindDire.Text = WindDireInt2String(data.GustDirection?[0]);
            L_todayWind.Text = data.Gust?[0].ToString();
            L_todayWindTime.Text = "(" + Hour2JstHour(data.GustTime?.Hour)?.ToString("D2") + ":" + data.GustTime?.Minute?.ToString("D2") + ")";

        }

        private void T_auto_Tick(object sender, EventArgs e)
        {
            GetAndView();
        }
    }
}
