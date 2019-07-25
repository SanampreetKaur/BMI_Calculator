namespace BMI_Calculator
{
    partial class BMI_CalculatorForm
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
            this.BMICalculatorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DoneButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightbutton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.BMICalculatorTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMICalculatorTableLayoutPanel
            // 
            this.BMICalculatorTableLayoutPanel.ColumnCount = 4;
            this.BMICalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.resultLabel, 0, 0);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.threeButton, 2, 3);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.twoButton, 1, 3);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.oneButton, 0, 3);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.sixButton, 2, 2);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.fiveButton, 1, 2);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.fourButton, 0, 2);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.nineButton, 2, 1);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.eightbutton, 1, 1);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.sevenButton, 0, 1);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.DecimalButton, 2, 4);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.Back_button, 3, 1);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.ClearButton, 3, 2);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.DoneButton, 3, 3);
            this.BMICalculatorTableLayoutPanel.Controls.Add(this.zeroButton, 0, 4);
            this.BMICalculatorTableLayoutPanel.Location = new System.Drawing.Point(163, 98);
            this.BMICalculatorTableLayoutPanel.Name = "BMICalculatorTableLayoutPanel";
            this.BMICalculatorTableLayoutPanel.RowCount = 5;
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMICalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BMICalculatorTableLayoutPanel.Size = new System.Drawing.Size(409, 339);
            this.BMICalculatorTableLayoutPanel.TabIndex = 0;
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DoneButton.BackColor = System.Drawing.Color.Silver;
            this.DoneButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.Location = new System.Drawing.Point(309, 204);
            this.DoneButton.Name = "DoneButton";
            this.BMICalculatorTableLayoutPanel.SetRowSpan(this.DoneButton, 2);
            this.DoneButton.Size = new System.Drawing.Size(97, 132);
            this.DoneButton.TabIndex = 11;
            this.DoneButton.Tag = "Done";
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.clickButton);
            // 
            // zeroButton
            // 
            this.zeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zeroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.zeroButton, 2);
            this.zeroButton.Location = new System.Drawing.Point(3, 271);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(198, 65);
            this.zeroButton.TabIndex = 10;
            this.zeroButton.Tag = "0";
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.clickButton);
            // 
            // threeButton
            // 
            this.threeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.threeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.threeButton.Location = new System.Drawing.Point(207, 204);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(96, 61);
            this.threeButton.TabIndex = 8;
            this.threeButton.Tag = "3";
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.clickButton);
            // 
            // twoButton
            // 
            this.twoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.twoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.twoButton.Location = new System.Drawing.Point(105, 204);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(96, 61);
            this.twoButton.TabIndex = 7;
            this.twoButton.Tag = "2";
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.clickButton);
            // 
            // oneButton
            // 
            this.oneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.oneButton.Location = new System.Drawing.Point(3, 204);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(96, 61);
            this.oneButton.TabIndex = 6;
            this.oneButton.Tag = "1";
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.clickButton);
            // 
            // sixButton
            // 
            this.sixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sixButton.Location = new System.Drawing.Point(207, 137);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(96, 61);
            this.sixButton.TabIndex = 5;
            this.sixButton.Tag = "6";
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.clickButton);
            // 
            // fiveButton
            // 
            this.fiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.fiveButton.Location = new System.Drawing.Point(105, 137);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(96, 61);
            this.fiveButton.TabIndex = 4;
            this.fiveButton.Tag = "5";
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.clickButton);
            // 
            // fourButton
            // 
            this.fourButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.fourButton.Location = new System.Drawing.Point(3, 137);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(96, 61);
            this.fourButton.TabIndex = 3;
            this.fourButton.Tag = "4";
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.clickButton);
            // 
            // nineButton
            // 
            this.nineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nineButton.Location = new System.Drawing.Point(207, 70);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(96, 61);
            this.nineButton.TabIndex = 2;
            this.nineButton.Tag = "9";
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.clickButton);
            // 
            // eightbutton
            // 
            this.eightbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eightbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.eightbutton.Location = new System.Drawing.Point(105, 70);
            this.eightbutton.Name = "eightbutton";
            this.eightbutton.Size = new System.Drawing.Size(96, 61);
            this.eightbutton.TabIndex = 1;
            this.eightbutton.Tag = "8";
            this.eightbutton.Text = "8";
            this.eightbutton.UseVisualStyleBackColor = false;
            this.eightbutton.Click += new System.EventHandler(this.clickButton);
            // 
            // sevenButton
            // 
            this.sevenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sevenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sevenButton.Location = new System.Drawing.Point(3, 70);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(96, 61);
            this.sevenButton.TabIndex = 0;
            this.sevenButton.Tag = "7";
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.clickButton);
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMICalculatorTableLayoutPanel.SetColumnSpan(this.resultLabel, 4);
            this.resultLabel.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(3, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(403, 67);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Tag = "result";
            this.resultLabel.Text = "0";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DecimalButton
            // 
            this.DecimalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecimalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DecimalButton.Location = new System.Drawing.Point(207, 271);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(96, 65);
            this.DecimalButton.TabIndex = 10;
            this.DecimalButton.Tag = "Decimal";
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = false;
            this.DecimalButton.Click += new System.EventHandler(this.clickButton);
            // 
            // Back_button
            // 
            this.Back_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Back_button.BackgroundImage = global::BMI_Calculator.Properties.Resources.backbutton;
            this.Back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Back_button.Location = new System.Drawing.Point(309, 70);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(97, 61);
            this.Back_button.TabIndex = 2;
            this.Back_button.Tag = "back";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.clickButton);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClearButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.Black;
            this.ClearButton.Location = new System.Drawing.Point(309, 137);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(97, 61);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Tag = "Clear";
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.clickButton);
            // 
            // OutputLabel
            // 
            this.OutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputLabel.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(166, 24);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(113, 59);
            this.OutputLabel.TabIndex = 1;
            this.OutputLabel.Tag = "result";
            this.OutputLabel.Text = "0";
            this.OutputLabel.Click += new System.EventHandler(this.outputLabel);
            // 
            // BMI_CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.BMICalculatorTableLayoutPanel);
            this.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMI_CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMI_CalculatorForm_Load);
            this.BMICalculatorTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMICalculatorTableLayoutPanel;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightbutton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label OutputLabel;
    }
}

