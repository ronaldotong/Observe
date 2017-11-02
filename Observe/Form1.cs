using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Observe.Weather;
namespace Observe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            weatherData = new WeatherData();
            currentDisplay = new CurrentConditionsDisplay(weatherData);
            statisticsDisplay = new StatisticsDisplay(weatherData);
            forecastDisplay = new ForecastDisplay(weatherData);
            heatIndexDisplay = new HeatIndexDisplay(weatherData);
            timer1.Enabled = true;
            timer1.Start();
        }

        private void ButtonbuttonSetMeasurements_Click(object sender, EventArgs e)
        {
            if (!textBoxTemperature.Text.Equals(string.Empty) &&
                !textBoxHumidity.Text.Equals(string.Empty) &&
                !textBoxPressure.Text.Equals(string.Empty))
            {
                float temperature = float.Parse(textBoxTemperature.Text);
                float humidity = float.Parse(textBoxHumidity.Text);
                float pressure = float.Parse(textBoxPressure.Text);
                weatherData.SetMeasurements(temperature, humidity, pressure);
            }
        }

        private WeatherData weatherData = null;
        private CurrentConditionsDisplay currentDisplay = null;
        private StatisticsDisplay statisticsDisplay = null;
        private ForecastDisplay forecastDisplay = null;
        private HeatIndexDisplay heatIndexDisplay = null;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!textBoxTemperature.Text.Equals(string.Empty) &&
                !textBoxHumidity.Text.Equals(string.Empty) &&
                !textBoxPressure.Text.Equals(string.Empty))
            {
                buttonbuttonSetMeasurements.Enabled = true;
            }
            else
            {
                buttonbuttonSetMeasurements.Enabled = false;
            }
        }
    }
}
