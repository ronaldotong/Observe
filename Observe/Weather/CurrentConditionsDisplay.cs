using System;

namespace Observe.Weather
{
    public class CurrentConditionsDisplay : DisplayBoard, IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
            labelBoardName.Text = "CurrentConditionsDisplay";
            Text = "CurrentConditionsDisplay";
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            richTextBox1.Text = "Current conditions: " + temperature
            + "F degrees and " + humidity + "% humidity";
            Show();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CurrentConditionsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "CurrentConditionsDisplay";
            this.Text = "CurrentConditionsDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}