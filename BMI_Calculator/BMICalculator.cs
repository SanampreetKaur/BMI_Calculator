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
        public double bmiresult { get; set; }

        public Animation animationField;


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



            animationField = Animation.IDLE;
        }
        private void CalculatorForm_Click(object sender, EventArgs e)
        {
            Clear_Numeric_Keyboard();
            if (Active_Label != null)
            {
                Active_Label.BackColor = Color.White;
            }
            Active_Label = null;
            
            animationField = Animation.DOWN;
            AnimationTimer.Enabled = true;

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
                        backspace();

                        break;

                    case "Decimal":
                        decimal_exsits();
                        break;

                    case "Done":

                        submit_result();

                        break;
                }
            }
        }

        private void submit_result()
        {
            if (outputStringResult == string.Empty)
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
            if (height_label.Text == "0")
            {
                height_label.Text = "0.1";
                Clear_Numeric_Keyboard();


                BMICalculatorTableLayoutPanel.Visible = false;

                Active_Label.BackColor = Color.White;
                Active_Label = null;

                animationField = Animation.DOWN;
                AnimationTimer.Enabled = true;

            }


            else if (Weight_label.Text == "0")
            {
                Weight_label.Text = "0.1";
                Clear_Numeric_Keyboard();


                BMICalculatorTableLayoutPanel.Visible = false;

                Active_Label.BackColor = Color.White;
                Active_Label = null;

                animationField = Animation.DOWN;
                AnimationTimer.Enabled = true;

            }
        }

        private void decimal_exsits()
        {
            if (!decimalResult)
            {
                outputStringResult += ".";
                decimalResult = true;
            }
        }

        private void backspace()
        {
            var end_char = outputStringResult.Substring(outputStringResult.Length - 1);
            if (end_char == ".")
            {
                decimalResult = false;
            }

            outputStringResult = outputStringResult.Remove(outputStringResult.Length - 1);
            if (outputStringResult.Length == 0)
            {
                outputStringResult = "0";
            }
            resultLabel.Text = outputStringResult;
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
        //    BMICalculatorTableLayoutPanel.Location = new Point(12, Active_Label.Location.Y + 55);
            BMICalculatorTableLayoutPanel.BringToFront();
            
            AnimationTimer.Enabled = true;

            animationField = Animation.UP;


        }

        /// <summary>
        /// this is the event handler for animation timer tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            switch (animationField)
            {
                case Animation.IDLE:
                    break;
                case Animation.UP:
                    UpKeyboard();
                    break;
                case Animation.DOWN:
                    DownKeyboard();
                    break;

            }

        }

        private void UpKeyboard()
        {
            var currentLocation = BMICalculatorTableLayoutPanel.Location;
            currentLocation = new Point(currentLocation.X, currentLocation.Y - 20);
            BMICalculatorTableLayoutPanel.Location = currentLocation;
            if (currentLocation.Y <= Active_Label.Location.Y + 35)
            {
                BMICalculatorTableLayoutPanel.Location = new Point(currentLocation.X, Active_Label.Location.Y + 35);
                AnimationTimer.Enabled = false;
                animationField = Animation.IDLE;
            }
        }
        private void DownKeyboard()
        {
            var currentLocation = BMICalculatorTableLayoutPanel.Location;
            currentLocation = new Point(currentLocation.X, currentLocation.Y + 20);
            BMICalculatorTableLayoutPanel.Location = currentLocation;
            if (currentLocation.Y >=466)
            {
                BMICalculatorTableLayoutPanel.Location = new Point(currentLocation.X, 466);
                AnimationTimer.Enabled = false;
                animationField = Animation.IDLE;
                BMICalculatorTableLayoutPanel.Visible = false;
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {


                double Height = Convert.ToDouble(height_label.Text);
                double Weight = Convert.ToDouble(Weight_label.Text);

                if (ImperialButton.Checked)
                {
                    bmiresult = Weight * 703 / Math.Pow(Height, 2);
                FinalOutput.Text = bmiresult.ToString();

                }
                else if (MetricButton.Checked)
                {
                    bmiresult = Weight / Math.Pow(Height, 2);
                FinalOutput.Text = bmiresult.ToString();
                }
            }

            //private void Reset_button_Click(object sender, EventArgs e)
            //{
            //    Clear_Numeric_Keyboard();
            //FinalOutput.Text = "";
            //height_label.Text = "";
            //Weight_label.Text = "";
            //}

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Clear_Numeric_Keyboard();
            FinalOutput.Text = "";
            height_label.Text = "";
            Weight_label.Text = "";
        }
    }
    }

