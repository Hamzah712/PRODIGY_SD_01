namespace PRODIGY_SD_01
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            InitializeComboBoxes();
            AttachEventHandlers();
        }

        private void InitializeComboBoxes()
        {
            string[] units = { "Celsius", "Fahrenheit", "Kelvin" };
            unit1ComboBox.Items.AddRange(units);
            unit2ComboBox.Items.AddRange(units);
            unit1ComboBox.SelectedIndex = 0;
            unit2ComboBox.SelectedIndex = 1;
        }

        private void AttachEventHandlers()
        {
            temp1TextBox.TextChanged += UpdateConversion;
            unit1ComboBox.SelectedIndexChanged += UpdateConversion;
            unit2ComboBox.SelectedIndexChanged += UpdateConversion;
            temp1TextBox.KeyPress += Temp1TextBox_KeyPress;
        }

        private void Temp1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, decimal point, negative sign, and control characters (like backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the keypress
            }
            else if (e.KeyChar == '.' && temp1TextBox.Text.Contains("."))
            {
                e.Handled = true; // Ignore additional decimal points
            }
            else if (e.KeyChar == '-' && temp1TextBox.Text.Length > 0 && temp1TextBox.SelectionStart != 0)
            {
                e.Handled = true; // Allow negative sign only at the beginning
            }
        }

        private void UpdateConversion(object sender, EventArgs e)
        {
            if (double.TryParse(temp1TextBox.Text, out double inputTemp))
            {
                string fromUnit = unit1ComboBox.SelectedItem?.ToString();
                string toUnit = unit2ComboBox.SelectedItem?.ToString();
                if (fromUnit != null && toUnit != null)
                {
                    double result = ConvertTemperature(inputTemp, fromUnit, toUnit);
                    temp2TextBox.Text = result.ToString("F2");
                }
            }
            else
            {
                temp2TextBox.Clear();
            }
        }

        private double ConvertTemperature(double temp, string fromUnit, string toUnit)
        {
            // Convert to Celsius first
            double celsiusTemp = fromUnit switch
            {
                "Celsius" => temp,
                "Fahrenheit" => FahrenheitToCelsius(temp),
                "Kelvin" => KelvinToCelsius(temp),
                _ => throw new ArgumentException("Invalid fromUnit")
            };

            // Then convert from Celsius to target unit
            return toUnit switch
            {
                "Celsius" => celsiusTemp,
                "Fahrenheit" => CelsiusToFahrenheit(celsiusTemp),
                "Kelvin" => CelsiusToKelvin(celsiusTemp),
                _ => throw new ArgumentException("Invalid toUnit")
            };
        }

        // Conversion methods
        public double CelsiusToFahrenheit(double celsius) => (celsius * 9 / 5) + 32;
        public double FahrenheitToCelsius(double fahrenheit) => (fahrenheit - 32) * 5 / 9;
        public double CelsiusToKelvin(double celsius) => celsius + 273.15;
        public double KelvinToCelsius(double kelvin) => kelvin - 273.15;
        public double FahrenheitToKelvin(double fahrenheit) => CelsiusToKelvin(FahrenheitToCelsius(fahrenheit));
        public double KelvinToFahrenheit(double kelvin) => CelsiusToFahrenheit(KelvinToCelsius(kelvin));


        // Buttons Event Handlers 
        private void button_0_Click(object sender, EventArgs e) { temp1TextBox.Text += "0"; }

        private void button_1_Click(object sender, EventArgs e) { temp1TextBox.Text += "1"; }

        private void button_2_Click(object sender, EventArgs e) { temp1TextBox.Text += "2"; }

        private void button_3_Click(object sender, EventArgs e) { temp1TextBox.Text += "3"; }

        private void button_4_Click(object sender, EventArgs e) { temp1TextBox.Text += "4"; }

        private void button_5_Click(object sender, EventArgs e) { temp1TextBox.Text += "5"; }

        private void button_6_Click(object sender, EventArgs e) { temp1TextBox.Text += "6"; }

        private void button_7_Click(object sender, EventArgs e) { temp1TextBox.Text += "7"; }

        private void button_8_Click(object sender, EventArgs e) { temp1TextBox.Text += "8"; }

        private void button_9_Click(object sender, EventArgs e) { temp1TextBox.Text += "9"; }

        private void clearButton_Click(object sender, EventArgs e) { temp1TextBox.Clear(); }

        private void dotButton_Click(object sender, EventArgs e)
        {
            if (!temp1TextBox.Text.Contains(".")) { temp1TextBox.Text += "."; }
        }

        private void plusMinusButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(temp1TextBox.Text, out double currentNum))
            {
                currentNum = -currentNum;

                temp1TextBox.Text = currentNum.ToString();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (temp1TextBox != null && temp1TextBox.Text.Length > 0) 
            { 
                temp1TextBox.Text = temp1TextBox.Text.Substring(0, temp1TextBox.Text.Length - 1);
            }
        }
    }
}