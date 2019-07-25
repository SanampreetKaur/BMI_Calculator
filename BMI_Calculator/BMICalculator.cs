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
        public BMI_CalculatorForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void clickButton(object sender, EventArgs e)
        {
            var Button = sender as Button;

            int Button_Value;
            bool result = int.TryParse(Button.Text, out Button_Value);
            if (result)
            {
                resultLabel.Text = Button.Text;
            }
        }
    }
}
