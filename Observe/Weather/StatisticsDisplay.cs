using System;

namespace Observe.Weather
{
    public class StatisticsDisplay : DisplayBoard, IObserver, IDisplayElement
    {
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;
        private WeatherData weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
            labelBoardName.Text = "ForecastDisplay";
        }

        public void Update(float temp, float humidity, float pressure)
        {
            tempSum += temp;
            numReadings++;

            if (temp > maxTemp)
            {
                maxTemp = temp;
            }

            if (temp < minTemp)
            {
                minTemp = temp;
            }

            Display();
        }

        public void Display()
        {
            richTextBox1.Text = "Avg/Max/Min temperature = " + (tempSum / numReadings)
                + "/" + maxTemp + "/" + minTemp;
            Show();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // StatisticsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "StatisticsDisplay";
            this.Text = "StatisticsDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}