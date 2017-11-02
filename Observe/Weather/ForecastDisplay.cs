using System;

namespace Observe.Weather
{
    public class ForecastDisplay : DisplayBoard, IObserver, IDisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
            labelBoardName.Text = "ForecastDisplay";
            Text = "ForecastDisplay";
        }

        public void Update(float temp, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;

            Display();
        }

        public void Display()
        {
            string text = "Forecast: \n";
            if (currentPressure > lastPressure)
            {
                text += "Improving weather on the way!";
            }
            else if (currentPressure == lastPressure)
            {
                text += "More of the same";
            }
            else if (currentPressure < lastPressure)
            {
                text += "Watch out for cooler, rainy weather";
            }
            richTextBox1.Text = text;
            Show();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ForecastDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "ForecastDisplay";
            this.Text = "ForecastDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}