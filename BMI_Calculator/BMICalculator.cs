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
        public Label Active_Label { get; set; }
        public BMI_CalculatorForm()
        {
            InitializeComponent();
        }

        private void BMI_CalculatorForm_Load(object sender, EventArgs e)
        {
            Clear_Numeric_Keyboard();
            Active_Label = null;
            BMICalculatorTableLayoutPanel.Visible = false;

           this.Size = new Size(320,480);
        }
        private void CalculatorForm_Click(object sender, EventArgs e)
        {
            Clear_Numeric_Keyboard();
            if (Active_Label != null)
            {
                Active_Label.BackColor = Color.White;
            }
            Active_Label = null;
            BMICalculatorTableLayoutPanel.Visible = false;

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
                int maxSize = (decimalResult) ? 5 : 3;
                if(outputStringResult == "0")
                {
                    outputStringResult = tag;
                }
                else
                { 
                    if(outputStringResult.Length< maxSize)
                    {
                        outputStringResult += tag;
                    }
                   
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

                        if(outputStringResult == string.Empty)
                        {
                            outputStringResult = "0";
                        }

                        resultValue = float.Parse(outputStringResult);
                        //resultValue = (float)(Math.Round(resultValue, 1));
                        //if (resultValue < 0.1f)
                        //{
                        //    resultValue = 0.1f;
                        //}
                        Active_Label.Text = resultValue.ToString();
                        Clear_Numeric_Keyboard();
                        BMICalculatorTableLayoutPanel.Visible = false;
                        Active_Label.BackColor = Color.White;
                        Active_Label = null;

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


        private void Active_Label_Click(object sender, EventArgs e)
        {
            if(Active_Label != null) 
            {
                Active_Label.BackColor = Color.White;
                Active_Label = null;
            }
            Active_Label = sender as Label;
            Active_Label.BackColor = Color.LightBlue;
            BMICalculatorTableLayoutPanel.Visible = true;
            if(Active_Label.Text != "0")
            {
                resultLabel.Text = Active_Label.Text;
                outputStringResult = resultLabel.Text;
            }
            BMICalculatorTableLayoutPanel.Location = new Point(12, Active_Label.Location.Y + 55);
            BMICalculatorTableLayoutPanel.BringToFront();
        }

     
    }
}
