namespace Observe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Temperature = new System.Windows.Forms.Label();
            this.Humidity = new System.Windows.Forms.Label();
            this.Pressure = new System.Windows.Forms.Label();
            this.textBoxTemperature = new System.Windows.Forms.TextBox();
            this.textBoxHumidity = new System.Windows.Forms.TextBox();
            this.textBoxPressure = new System.Windows.Forms.TextBox();
            this.buttonbuttonSetMeasurements = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Temperature
            // 
            this.Temperature.AutoSize = true;
            this.Temperature.Location = new System.Drawing.Point(33, 44);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(67, 13);
            this.Temperature.TabIndex = 0;
            this.Temperature.Text = "Temperature";
            // 
            // Humidity
            // 
            this.Humidity.AutoSize = true;
            this.Humidity.Location = new System.Drawing.Point(33, 78);
            this.Humidity.Name = "Humidity";
            this.Humidity.Size = new System.Drawing.Size(47, 13);
            this.Humidity.TabIndex = 1;
            this.Humidity.Text = "Humidity";
            // 
            // Pressure
            // 
            this.Pressure.AutoSize = true;
            this.Pressure.Location = new System.Drawing.Point(33, 112);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(48, 13);
            this.Pressure.TabIndex = 2;
            this.Pressure.Text = "Pressure";
            // 
            // textBox1
            // 
            this.textBoxTemperature.Location = new System.Drawing.Point(135, 44);
            this.textBoxTemperature.Name = "textBox1";
            this.textBoxTemperature.Size = new System.Drawing.Size(100, 20);
            this.textBoxTemperature.TabIndex = 3;
            this.textBoxTemperature.Text = "100";
            // 
            // textBox2
            // 
            this.textBoxHumidity.Location = new System.Drawing.Point(135, 78);
            this.textBoxHumidity.Name = "textBox2";
            this.textBoxHumidity.Size = new System.Drawing.Size(100, 20);
            this.textBoxHumidity.TabIndex = 4;
            this.textBoxHumidity.Text = "50";
            // 
            // textBox3
            // 
            this.textBoxPressure.Location = new System.Drawing.Point(135, 109);
            this.textBoxPressure.Name = "textBox3";
            this.textBoxPressure.Size = new System.Drawing.Size(100, 20);
            this.textBoxPressure.TabIndex = 5;
            this.textBoxPressure.Text = "30";
            // 
            // buttonbuttonSetMeasurements
            // 
            this.buttonbuttonSetMeasurements.Location = new System.Drawing.Point(36, 176);
            this.buttonbuttonSetMeasurements.Name = "buttonbuttonSetMeasurements";
            this.buttonbuttonSetMeasurements.Size = new System.Drawing.Size(75, 23);
            this.buttonbuttonSetMeasurements.TabIndex = 6;
            this.buttonbuttonSetMeasurements.Text = "SetMeasurements";
            this.buttonbuttonSetMeasurements.UseVisualStyleBackColor = true;
            this.buttonbuttonSetMeasurements.Click += new System.EventHandler(this.ButtonbuttonSetMeasurements_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonbuttonSetMeasurements);
            this.Controls.Add(this.textBoxPressure);
            this.Controls.Add(this.textBoxHumidity);
            this.Controls.Add(this.textBoxTemperature);
            this.Controls.Add(this.Pressure);
            this.Controls.Add(this.Humidity);
            this.Controls.Add(this.Temperature);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Temperature;
        private System.Windows.Forms.Label Humidity;
        private System.Windows.Forms.Label Pressure;
        private System.Windows.Forms.TextBox textBoxTemperature;
        private System.Windows.Forms.TextBox textBoxHumidity;
        private System.Windows.Forms.TextBox textBoxPressure;
        private System.Windows.Forms.Button buttonbuttonSetMeasurements;
        private System.Windows.Forms.Timer timer1;
    }
}

