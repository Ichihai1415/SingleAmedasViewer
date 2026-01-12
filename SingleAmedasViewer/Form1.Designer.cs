namespace SingleAmedasViewer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            L_obsName = new Label();
            L_obsInfo = new Label();
            L_Back_text1 = new Label();
            L_temp = new Label();
            L_rain10m = new Label();
            L_rain1h = new Label();
            L_rain3h = new Label();
            L_rain24h = new Label();
            L_windDire = new Label();
            L_wind = new Label();
            L_sun10m = new Label();
            L_sun1h = new Label();
            L_humid = new Label();
            L_press = new Label();
            L_pressKaimen = new Label();
            L_sitei = new Label();
            L_h_weather = new Label();
            L_h_snowH = new Label();
            L_h_snow1h = new Label();
            L_h_snow6h = new Label();
            L_h_snow12h = new Label();
            L_h_snow24h = new Label();
            L_updateTime = new Label();
            L_Design_line1 = new Label();
            L_obsNameKana = new Label();
            L_todayTemp = new Label();
            L_todayTempTime = new Label();
            L_todayWindDire = new Label();
            L_todayWind = new Label();
            L_todayWindTime = new Label();
            L_obsPref = new Label();
            T_auto = new System.Windows.Forms.Timer(components);
            L_obsCode = new Label();
            SuspendLayout();
            // 
            // L_obsName
            // 
            L_obsName.AutoSize = true;
            L_obsName.Font = new Font("Yu Gothic UI", 22F);
            L_obsName.ForeColor = SystemColors.Control;
            L_obsName.ImageAlign = ContentAlignment.BottomLeft;
            L_obsName.Location = new Point(210, 12);
            L_obsName.Margin = new Padding(4, 0, 4, 0);
            L_obsName.Name = "L_obsName";
            L_obsName.Size = new Size(228, 41);
            L_obsName.TabIndex = 1;
            L_obsName.Text = "観測点名観測点";
            // 
            // L_obsInfo
            // 
            L_obsInfo.Font = new Font("Yu Gothic UI", 12F);
            L_obsInfo.ForeColor = SystemColors.Control;
            L_obsInfo.Location = new Point(251, 2);
            L_obsInfo.Margin = new Padding(4, 0, 4, 0);
            L_obsInfo.Name = "L_obsInfo";
            L_obsInfo.Size = new Size(549, 50);
            L_obsInfo.TabIndex = 2;
            L_obsInfo.Text = "北緯 00度00.0分, 東経 000度00.0分\r\n種別: 種別種・別種別種別種別種別(管)  標高 0000m";
            L_obsInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // L_Back_text1
            // 
            L_Back_text1.AutoSize = true;
            L_Back_text1.Location = new Point(3, 68);
            L_Back_text1.Margin = new Padding(4, 0, 4, 0);
            L_Back_text1.Name = "L_Back_text1";
            L_Back_text1.Size = new Size(796, 315);
            L_Back_text1.TabIndex = 3;
            L_Back_text1.Text = resources.GetString("L_Back_text1.Text");
            // 
            // L_temp
            // 
            L_temp.Font = new Font("Yu Gothic UI", 28F);
            L_temp.ForeColor = SystemColors.Control;
            L_temp.Location = new Point(43, 88);
            L_temp.Margin = new Padding(4, 0, 4, 0);
            L_temp.Name = "L_temp";
            L_temp.Size = new Size(105, 51);
            L_temp.TabIndex = 4;
            L_temp.Text = "-00.0";
            L_temp.TextAlign = ContentAlignment.MiddleRight;
            // 
            // L_rain10m
            // 
            L_rain10m.Font = new Font("Yu Gothic UI", 28F);
            L_rain10m.ForeColor = SystemColors.Control;
            L_rain10m.Location = new Point(59, 151);
            L_rain10m.Margin = new Padding(4, 0, 4, 0);
            L_rain10m.Name = "L_rain10m";
            L_rain10m.Size = new Size(90, 51);
            L_rain10m.TabIndex = 5;
            L_rain10m.Text = "00.0";
            L_rain10m.TextAlign = ContentAlignment.MiddleRight;
            // 
            // L_rain1h
            // 
            L_rain1h.Font = new Font("Yu Gothic UI", 28F);
            L_rain1h.ForeColor = SystemColors.Control;
            L_rain1h.Location = new Point(223, 151);
            L_rain1h.Margin = new Padding(4, 0, 4, 0);
            L_rain1h.Name = "L_rain1h";
            L_rain1h.Size = new Size(110, 51);
            L_rain1h.TabIndex = 6;
            L_rain1h.Text = "000.0";
            L_rain1h.TextAlign = ContentAlignment.MiddleRight;
            // 
            // L_rain3h
            // 
            L_rain3h.Font = new Font("Yu Gothic UI", 28F);
            L_rain3h.ForeColor = SystemColors.Control;
            L_rain3h.Location = new Point(385, 151);
            L_rain3h.Margin = new Padding(4, 0, 4, 0);
            L_rain3h.Name = "L_rain3h";
            L_rain3h.Size = new Size(110, 51);
            L_rain3h.TabIndex = 7;
            L_rain3h.Text = "000.0";
            L_rain3h.TextAlign = ContentAlignment.MiddleRight;
            // 
            // L_rain24h
            // 
            L_rain24h.Font = new Font("Yu Gothic UI", 28F);
            L_rain24h.ForeColor = SystemColors.Control;
            L_rain24h.Location = new Point(556, 151);
            L_rain24h.Margin = new Padding(4, 0, 4, 0);
            L_rain24h.Name = "L_rain24h";
            L_rain24h.Size = new Size(110, 51);
            L_rain24h.TabIndex = 8;
            L_rain24h.Text = "000.0";
            L_rain24h.TextAlign = ContentAlignment.MiddleRight;
            // 
            // L_windDire
            // 
            L_windDire.Font = new Font("Yu Gothic UI", 24F);
            L_windDire.ForeColor = SystemColors.Control;
            L_windDire.Location = new Point(26, 218);
            L_windDire.Margin = new Padding(2, 0, 2, 0);
            L_windDire.Name = "L_windDire";
            L_windDire.Size = new Size(116, 45);
            L_windDire.TabIndex = 9;
            L_windDire.Text = "風方向";
            L_windDire.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // L_wind
            // 
            L_wind.Font = new Font("Yu Gothic UI", 28F);
            L_wind.ForeColor = SystemColors.Control;
            L_wind.Location = new Point(126, 215);
            L_wind.Margin = new Padding(2, 0, 2, 0);
            L_wind.Name = "L_wind";
            L_wind.Size = new Size(90, 51);
            L_wind.TabIndex = 10;
            L_wind.Text = "00.0";
            L_wind.TextAlign = ContentAlignment.MiddleRight;
            // 
            // L_sun10m
            // 
            L_sun10m.Font = new Font("Yu Gothic UI", 28F);
            L_sun10m.ForeColor = SystemColors.Control;
            L_sun10m.Location = new Point(328, 215);
            L_sun10m.Margin = new Padding(2, 0, 2, 0);
            L_sun10m.Name = "L_sun10m";
            L_sun10m.Size = new Size(62, 51);
            L_sun10m.TabIndex = 11;
            L_sun10m.Text = "00";
            L_sun10m.TextAlign = ContentAlignment.MiddleRight;
            // 
            // L_sun1h
            // 
            L_sun1h.Font = new Font("Yu Gothic UI", 28F);
            L_sun1h.ForeColor = SystemColors.Control;
            L_sun1h.Location = new Point(450, 215);
            L_sun1h.Margin = new Padding(2, 0, 2, 0);
            L_sun1h.Name = "L_sun1h";
            L_sun1h.Size = new Size(70, 51);
            L_sun1h.TabIndex = 12;
            L_sun1h.Text = "0.0";
            L_sun1h.TextAlign = ContentAlignment.MiddleRight;
            // 
            // L_humid
            // 
            L_humid.Font = new Font("Yu Gothic UI", 28F);
            L_humid.ForeColor = SystemColors.Control;
            L_humid.Location = new Point(217, 88);
            L_humid.Margin = new Padding(2, 0, 2, 0);
            L_humid.Name = "L_humid";
            L_humid.Size = new Size(82, 51);
            L_humid.TabIndex = 13;
            L_humid.Text = "100";
            L_humid.TextAlign = ContentAlignment.MiddleRight;
            // 
            // L_press
            // 
            L_press.Font = new Font("Yu Gothic UI", 28F);
            L_press.ForeColor = SystemColors.Control;
            L_press.Location = new Point(395, 88);
            L_press.Margin = new Padding(2, 0, 2, 0);
            L_press.Name = "L_press";
            L_press.Size = new Size(130, 51);
            L_press.TabIndex = 14;
            L_press.Text = "1000.0";
            L_press.TextAlign = ContentAlignment.MiddleRight;
            // 
            // L_pressKaimen
            // 
            L_pressKaimen.Font = new Font("Yu Gothic UI", 28F);
            L_pressKaimen.ForeColor = SystemColors.Control;
            L_pressKaimen.Location = new Point(635, 88);
            L_pressKaimen.Margin = new Padding(2, 0, 2, 0);
            L_pressKaimen.Name = "L_pressKaimen";
            L_pressKaimen.Size = new Size(130, 51);
            L_pressKaimen.TabIndex = 15;
            L_pressKaimen.Text = "0000.0";
            L_pressKaimen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // L_sitei
            // 
            L_sitei.Font = new Font("Yu Gothic UI", 28F);
            L_sitei.ForeColor = SystemColors.Control;
            L_sitei.Location = new Point(596, 215);
            L_sitei.Margin = new Padding(2, 0, 2, 0);
            L_sitei.Name = "L_sitei";
            L_sitei.Size = new Size(110, 51);
            L_sitei.TabIndex = 16;
            L_sitei.Text = "00.00";
            L_sitei.TextAlign = ContentAlignment.MiddleRight;
            // 
            // L_h_weather
            // 
            L_h_weather.AutoSize = true;
            L_h_weather.Font = new Font("Yu Gothic UI", 28F);
            L_h_weather.ForeColor = SystemColors.Control;
            L_h_weather.Location = new Point(535, 338);
            L_h_weather.Margin = new Padding(2, 0, 2, 0);
            L_h_weather.Name = "L_h_weather";
            L_h_weather.Size = new Size(250, 51);
            L_h_weather.TabIndex = 17;
            L_h_weather.Text = "天気天気天気";
            // 
            // L_h_snowH
            // 
            L_h_snowH.Font = new Font("Yu Gothic UI", 28F);
            L_h_snowH.ForeColor = SystemColors.Control;
            L_h_snowH.Location = new Point(58, 279);
            L_h_snowH.Margin = new Padding(2, 0, 2, 0);
            L_h_snowH.Name = "L_h_snowH";
            L_h_snowH.Size = new Size(82, 51);
            L_h_snowH.TabIndex = 18;
            L_h_snowH.Text = "000";
            L_h_snowH.TextAlign = ContentAlignment.MiddleRight;
            // 
            // L_h_snow1h
            // 
            L_h_snow1h.Font = new Font("Yu Gothic UI", 28F);
            L_h_snow1h.ForeColor = SystemColors.Control;
            L_h_snow1h.Location = new Point(229, 277);
            L_h_snow1h.Margin = new Padding(2, 0, 2, 0);
            L_h_snow1h.Name = "L_h_snow1h";
            L_h_snow1h.Size = new Size(62, 51);
            L_h_snow1h.TabIndex = 19;
            L_h_snow1h.Text = "00";
            L_h_snow1h.TextAlign = ContentAlignment.MiddleRight;
            // 
            // L_h_snow6h
            // 
            L_h_snow6h.Font = new Font("Yu Gothic UI", 28F);
            L_h_snow6h.ForeColor = SystemColors.Control;
            L_h_snow6h.Location = new Point(336, 278);
            L_h_snow6h.Margin = new Padding(2, 0, 2, 0);
            L_h_snow6h.Name = "L_h_snow6h";
            L_h_snow6h.Size = new Size(62, 51);
            L_h_snow6h.TabIndex = 20;
            L_h_snow6h.Text = "00";
            L_h_snow6h.TextAlign = ContentAlignment.MiddleRight;
            // 
            // L_h_snow12h
            // 
            L_h_snow12h.Font = new Font("Yu Gothic UI", 28F);
            L_h_snow12h.ForeColor = SystemColors.Control;
            L_h_snow12h.Location = new Point(452, 278);
            L_h_snow12h.Margin = new Padding(2, 0, 2, 0);
            L_h_snow12h.Name = "L_h_snow12h";
            L_h_snow12h.Size = new Size(82, 51);
            L_h_snow12h.TabIndex = 21;
            L_h_snow12h.Text = "000";
            L_h_snow12h.TextAlign = ContentAlignment.MiddleRight;
            // 
            // L_h_snow24h
            // 
            L_h_snow24h.Font = new Font("Yu Gothic UI", 28F);
            L_h_snow24h.ForeColor = SystemColors.Control;
            L_h_snow24h.Location = new Point(597, 277);
            L_h_snow24h.Margin = new Padding(2, 0, 2, 0);
            L_h_snow24h.Name = "L_h_snow24h";
            L_h_snow24h.Size = new Size(82, 51);
            L_h_snow24h.TabIndex = 22;
            L_h_snow24h.Text = "000";
            L_h_snow24h.TextAlign = ContentAlignment.MiddleRight;
            // 
            // L_updateTime
            // 
            L_updateTime.ForeColor = SystemColors.Control;
            L_updateTime.Location = new Point(43, 68);
            L_updateTime.Name = "L_updateTime";
            L_updateTime.Size = new Size(137, 21);
            L_updateTime.TabIndex = 23;
            L_updateTime.Text = "0000/00/00 00:00";
            // 
            // L_Design_line1
            // 
            L_Design_line1.BackColor = SystemColors.ControlDark;
            L_Design_line1.Location = new Point(0, 54);
            L_Design_line1.Margin = new Padding(0);
            L_Design_line1.Name = "L_Design_line1";
            L_Design_line1.Size = new Size(800, 2);
            L_Design_line1.TabIndex = 25;
            // 
            // L_obsNameKana
            // 
            L_obsNameKana.AutoSize = true;
            L_obsNameKana.Font = new Font("Yu Gothic UI", 8F);
            L_obsNameKana.ForeColor = SystemColors.Control;
            L_obsNameKana.ImageAlign = ContentAlignment.BottomLeft;
            L_obsNameKana.Location = new Point(215, 3);
            L_obsNameKana.Margin = new Padding(4, 0, 4, 0);
            L_obsNameKana.Name = "L_obsNameKana";
            L_obsNameKana.Size = new Size(83, 13);
            L_obsNameKana.TabIndex = 26;
            L_obsNameKana.Text = "カタカナ観測点名";
            // 
            // L_todayTemp
            // 
            L_todayTemp.Font = new Font("Yu Gothic UI", 12F);
            L_todayTemp.ForeColor = SystemColors.Control;
            L_todayTemp.Location = new Point(119, 340);
            L_todayTemp.Margin = new Padding(2, 0, 2, 0);
            L_todayTemp.Name = "L_todayTemp";
            L_todayTemp.Size = new Size(46, 42);
            L_todayTemp.TabIndex = 27;
            L_todayTemp.Text = "-00.0\r\n-00.0";
            L_todayTemp.TextAlign = ContentAlignment.MiddleRight;
            // 
            // L_todayTempTime
            // 
            L_todayTempTime.Font = new Font("Yu Gothic UI", 12F);
            L_todayTempTime.ForeColor = SystemColors.Control;
            L_todayTempTime.Location = new Point(182, 340);
            L_todayTempTime.Margin = new Padding(2, 0, 2, 0);
            L_todayTempTime.Name = "L_todayTempTime";
            L_todayTempTime.Size = new Size(59, 42);
            L_todayTempTime.TabIndex = 28;
            L_todayTempTime.Text = "(00:00)\r\n(00:00)";
            // 
            // L_todayWindDire
            // 
            L_todayWindDire.Font = new Font("Yu Gothic UI", 12F);
            L_todayWindDire.ForeColor = SystemColors.Control;
            L_todayWindDire.Location = new Point(247, 362);
            L_todayWindDire.Margin = new Padding(2, 0, 2, 0);
            L_todayWindDire.Name = "L_todayWindDire";
            L_todayWindDire.Size = new Size(58, 21);
            L_todayWindDire.TabIndex = 29;
            L_todayWindDire.Text = "風方向";
            L_todayWindDire.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // L_todayWind
            // 
            L_todayWind.Font = new Font("Yu Gothic UI", 12F);
            L_todayWind.ForeColor = SystemColors.Control;
            L_todayWind.Location = new Point(299, 362);
            L_todayWind.Margin = new Padding(2, 0, 2, 0);
            L_todayWind.Name = "L_todayWind";
            L_todayWind.Size = new Size(40, 21);
            L_todayWind.TabIndex = 30;
            L_todayWind.Text = "00.0";
            L_todayWind.TextAlign = ContentAlignment.MiddleRight;
            // 
            // L_todayWindTime
            // 
            L_todayWindTime.Font = new Font("Yu Gothic UI", 12F);
            L_todayWindTime.ForeColor = SystemColors.Control;
            L_todayWindTime.Location = new Point(365, 361);
            L_todayWindTime.Margin = new Padding(2, 0, 2, 0);
            L_todayWindTime.Name = "L_todayWindTime";
            L_todayWindTime.Size = new Size(59, 21);
            L_todayWindTime.TabIndex = 31;
            L_todayWindTime.Text = "(00:00)";
            // 
            // L_obsPref
            // 
            L_obsPref.AutoSize = true;
            L_obsPref.Font = new Font("Yu Gothic UI", 16F);
            L_obsPref.ForeColor = SystemColors.Control;
            L_obsPref.Location = new Point(3, 18);
            L_obsPref.Margin = new Padding(4, 0, 4, 0);
            L_obsPref.Name = "L_obsPref";
            L_obsPref.Size = new Size(211, 30);
            L_obsPref.TabIndex = 0;
            L_obsPref.Text = "都道府県北海道地方";
            // 
            // T_auto
            // 
            T_auto.Tick += T_auto_Tick;
            // 
            // L_obsCode
            // 
            L_obsCode.AutoSize = true;
            L_obsCode.Font = new Font("Yu Gothic UI", 8F);
            L_obsCode.ForeColor = SystemColors.Control;
            L_obsCode.ImageAlign = ContentAlignment.BottomLeft;
            L_obsCode.Location = new Point(3, 3);
            L_obsCode.Margin = new Padding(4, 0, 4, 0);
            L_obsCode.Name = "L_obsCode";
            L_obsCode.Size = new Size(63, 13);
            L_obsCode.TabIndex = 32;
            L_obsCode.Text = "観測点コード";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(800, 400);
            Controls.Add(L_obsCode);
            Controls.Add(L_todayWindTime);
            Controls.Add(L_todayWind);
            Controls.Add(L_todayWindDire);
            Controls.Add(L_todayTempTime);
            Controls.Add(L_todayTemp);
            Controls.Add(L_obsNameKana);
            Controls.Add(L_Design_line1);
            Controls.Add(L_updateTime);
            Controls.Add(L_h_snow24h);
            Controls.Add(L_h_snow12h);
            Controls.Add(L_h_snow6h);
            Controls.Add(L_h_snow1h);
            Controls.Add(L_h_snowH);
            Controls.Add(L_h_weather);
            Controls.Add(L_sitei);
            Controls.Add(L_pressKaimen);
            Controls.Add(L_press);
            Controls.Add(L_humid);
            Controls.Add(L_sun1h);
            Controls.Add(L_sun10m);
            Controls.Add(L_wind);
            Controls.Add(L_windDire);
            Controls.Add(L_rain24h);
            Controls.Add(L_rain3h);
            Controls.Add(L_rain1h);
            Controls.Add(L_rain10m);
            Controls.Add(L_temp);
            Controls.Add(L_Back_text1);
            Controls.Add(L_obsName);
            Controls.Add(L_obsPref);
            Controls.Add(L_obsInfo);
            Font = new Font("Yu Gothic UI", 12F);
            ForeColor = Color.Silver;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "SingleAmedasViewer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label L_obsName;
        private Label L_obsInfo;
        private Label L_Back_text1;
        private Label L_temp;
        private Label L_rain10m;
        private Label L_rain1h;
        private Label L_rain3h;
        private Label L_rain24h;
        private Label L_windDire;
        private Label L_wind;
        private Label L_sun10m;
        private Label L_sun1h;
        private Label L_humid;
        private Label L_press;
        private Label L_pressKaimen;
        private Label L_sitei;
        private Label L_h_weather;
        private Label L_h_snowH;
        private Label L_h_snow1h;
        private Label L_h_snow6h;
        private Label L_h_snow12h;
        private Label L_h_snow24h;
        private Label L_updateTime;
        private Label L_Design_line1;
        private Label L_obsNameKana;
        private Label L_todayTemp;
        private Label L_todayTempTime;
        private Label L_todayWindDire;
        private Label L_todayWind;
        private Label L_todayWindTime;
        private Label L_obsPref;
        private System.Windows.Forms.Timer T_auto;
        private Label L_obsCode;
    }
}
