using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{


    public partial class BMI_CalculatorForm : Form
    {
        public string outputStringResult { get; set; }
        public float resultValue { get; set; }
        public bool decimalResult {get; set;}

        public BMI_CalculatorForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void clickButton(object sender, EventArgs e)
        {
            Button Button = sender as Button;

            var tag = Button.Tag.ToString();
            int numericValue = 0;

           
            bool result = int.TryParse(tag, out numericValue);
            if (result)
            {
                if(outputStringResult == "0")
                {
                    outputStringResult = tag;
                }
                else
                {
                    outputStringResult += tag;
                    resultLabel.Text = outputStringResult;
                }
               
            }
            else
            {
                switch (tag)
                {
                    case "Clear":
                        Clear_Numeric_Keyboard();
                        break;

                    case "back":
                        var end_char = outputStringResult.Substring(outputStringResult.Length - 1);
                        if(end_char == ".")
                        {
                            decimalResult = false;
                        }

                        outputStringResult = outputStringResult.Remove(outputStringResult.Length - 1);
                        if(outputStringResult.Length == 0)
                        {
                            outputStringResult = "0";
                        }
                        resultLabel.Text = outputStringResult;

                        break;

                    case "Decimal":
                        if (!decimalResult)
                        {
                            outputStringResult += ".";
                            decimalResult = true;
                        }
                        break;

                    case "Done":
                        resultValue = float.Parse(outputStringResult);
                        resultLabel.Text = resultValue.ToString();
                        Clear_Numeric_Keyboard();
               
                        BMICalculatorTableLayoutPanel.Visible = false;
                        break;
                }
            }
        }

        private void Clear_Numeric_Keyboard()
        {
            outputStringResult = "0";
            resultLabel.Text = "0";
            decimalResult = false;
            resultValue = 0.0f;
        }

        private void BMI_CalculatorForm_Load(object sender, EventArgs e)
        {
            Clear_Numeric_Keyboard();
            BMICalculatorTableLayoutPanel.Visible = false;
        }

        private void outputLabel(object sender, EventArgs e)
        {
            BMICalculatorTableLayoutPanel.Visible = true;
        }
    }
}
