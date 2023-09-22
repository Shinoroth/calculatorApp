namespace calculatorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            resultTextBox = new TextBox();
            clearButton = new Button();
            pictureBox1 = new PictureBox();
            backspaceButton = new Button();
            openingBracketButton = new Button();
            closingBracketButton = new Button();
            digitButton_8 = new Button();
            digitButton_7 = new Button();
            digitButton_9 = new Button();
            digitButton_6 = new Button();
            digitButton_5 = new Button();
            digitButton_4 = new Button();
            digitButton_3 = new Button();
            digitButton_2 = new Button();
            digitButton_1 = new Button();
            showResultButton = new Button();
            digitButton_0 = new Button();
            separatorButton = new Button();
            operationButton_add = new Button();
            operationButton_substract = new Button();
            operationButton_multiply = new Button();
            operationButton_divide = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // resultTextBox
            // 
            resultTextBox.Font = new Font("Poppins Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
            resultTextBox.ForeColor = SystemColors.WindowFrame;
            resultTextBox.Location = new Point(33, 44);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.RightToLeft = RightToLeft.Yes;
            resultTextBox.Size = new Size(198, 37);
            resultTextBox.TabIndex = 0;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Transparent;
            clearButton.BackgroundImage = (Image)resources.GetObject("clearButton.BackgroundImage");
            clearButton.BackgroundImageLayout = ImageLayout.Center;
            clearButton.FlatAppearance.BorderSize = 0;
            clearButton.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            clearButton.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clearButton.ForeColor = SystemColors.ControlDarkDark;
            clearButton.Location = new Point(33, 84);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(45, 45);
            clearButton.TabIndex = 1;
            clearButton.Text = "C";
            clearButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calculator_background_image1;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 340);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // backspaceButton
            // 
            backspaceButton.BackgroundImage = Properties.Resources.button_background_image;
            backspaceButton.FlatAppearance.BorderSize = 0;
            backspaceButton.FlatStyle = FlatStyle.Flat;
            backspaceButton.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            backspaceButton.ForeColor = SystemColors.ControlDarkDark;
            backspaceButton.Location = new Point(186, 84);
            backspaceButton.Name = "backspaceButton";
            backspaceButton.Size = new Size(45, 45);
            backspaceButton.TabIndex = 3;
            backspaceButton.Text = "←";
            backspaceButton.TextAlign = ContentAlignment.TopCenter;
            backspaceButton.UseVisualStyleBackColor = true;
            // 
            // openingBracketButton
            // 
            openingBracketButton.BackgroundImage = Properties.Resources.button_background_image;
            openingBracketButton.FlatAppearance.BorderSize = 0;
            openingBracketButton.FlatStyle = FlatStyle.Flat;
            openingBracketButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            openingBracketButton.ForeColor = SystemColors.ControlDarkDark;
            openingBracketButton.Location = new Point(84, 84);
            openingBracketButton.Name = "openingBracketButton";
            openingBracketButton.Size = new Size(45, 45);
            openingBracketButton.TabIndex = 4;
            openingBracketButton.Text = "(";
            openingBracketButton.UseVisualStyleBackColor = true;
            // 
            // closingBracketButton
            // 
            closingBracketButton.BackgroundImage = Properties.Resources.button_background_image;
            closingBracketButton.FlatAppearance.BorderSize = 0;
            closingBracketButton.FlatStyle = FlatStyle.Flat;
            closingBracketButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            closingBracketButton.ForeColor = SystemColors.ControlDarkDark;
            closingBracketButton.Location = new Point(135, 84);
            closingBracketButton.Name = "closingBracketButton";
            closingBracketButton.Size = new Size(45, 45);
            closingBracketButton.TabIndex = 5;
            closingBracketButton.Text = ")";
            closingBracketButton.UseVisualStyleBackColor = true;
            // 
            // digitButton_8
            // 
            digitButton_8.BackgroundImage = Properties.Resources.button_background_image;
            digitButton_8.FlatAppearance.BorderSize = 0;
            digitButton_8.FlatStyle = FlatStyle.Flat;
            digitButton_8.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            digitButton_8.ForeColor = SystemColors.ControlDarkDark;
            digitButton_8.Location = new Point(84, 135);
            digitButton_8.Name = "digitButton_8";
            digitButton_8.Size = new Size(45, 45);
            digitButton_8.TabIndex = 8;
            digitButton_8.Text = "8";
            digitButton_8.UseVisualStyleBackColor = true;
            // 
            // digitButton_7
            // 
            digitButton_7.BackgroundImage = Properties.Resources.button_background_image;
            digitButton_7.FlatAppearance.BorderSize = 0;
            digitButton_7.FlatStyle = FlatStyle.Flat;
            digitButton_7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            digitButton_7.ForeColor = SystemColors.ControlDarkDark;
            digitButton_7.Location = new Point(33, 135);
            digitButton_7.Name = "digitButton_7";
            digitButton_7.Size = new Size(45, 45);
            digitButton_7.TabIndex = 6;
            digitButton_7.Text = "7";
            digitButton_7.UseVisualStyleBackColor = true;
            // 
            // digitButton_9
            // 
            digitButton_9.BackgroundImage = Properties.Resources.button_background_image;
            digitButton_9.FlatAppearance.BorderSize = 0;
            digitButton_9.FlatStyle = FlatStyle.Flat;
            digitButton_9.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            digitButton_9.ForeColor = SystemColors.ControlDarkDark;
            digitButton_9.Location = new Point(135, 135);
            digitButton_9.Name = "digitButton_9";
            digitButton_9.Size = new Size(45, 45);
            digitButton_9.TabIndex = 9;
            digitButton_9.Text = "9";
            digitButton_9.UseVisualStyleBackColor = true;
            // 
            // digitButton_6
            // 
            digitButton_6.BackgroundImage = Properties.Resources.button_background_image;
            digitButton_6.FlatAppearance.BorderSize = 0;
            digitButton_6.FlatStyle = FlatStyle.Flat;
            digitButton_6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            digitButton_6.ForeColor = SystemColors.ControlDarkDark;
            digitButton_6.Location = new Point(135, 186);
            digitButton_6.Name = "digitButton_6";
            digitButton_6.Size = new Size(45, 45);
            digitButton_6.TabIndex = 12;
            digitButton_6.Text = "6";
            digitButton_6.UseVisualStyleBackColor = true;
            // 
            // digitButton_5
            // 
            digitButton_5.BackgroundImage = Properties.Resources.button_background_image;
            digitButton_5.FlatAppearance.BorderSize = 0;
            digitButton_5.FlatStyle = FlatStyle.Flat;
            digitButton_5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            digitButton_5.ForeColor = SystemColors.ControlDarkDark;
            digitButton_5.Location = new Point(84, 186);
            digitButton_5.Name = "digitButton_5";
            digitButton_5.Size = new Size(45, 45);
            digitButton_5.TabIndex = 11;
            digitButton_5.Text = "5";
            digitButton_5.UseVisualStyleBackColor = true;
            // 
            // digitButton_4
            // 
            digitButton_4.BackgroundImage = Properties.Resources.button_background_image;
            digitButton_4.FlatAppearance.BorderSize = 0;
            digitButton_4.FlatStyle = FlatStyle.Flat;
            digitButton_4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            digitButton_4.ForeColor = SystemColors.ControlDarkDark;
            digitButton_4.Location = new Point(33, 186);
            digitButton_4.Name = "digitButton_4";
            digitButton_4.Size = new Size(45, 45);
            digitButton_4.TabIndex = 10;
            digitButton_4.Text = "4";
            digitButton_4.UseVisualStyleBackColor = true;
            // 
            // digitButton_3
            // 
            digitButton_3.BackgroundImage = Properties.Resources.button_background_image;
            digitButton_3.FlatAppearance.BorderSize = 0;
            digitButton_3.FlatStyle = FlatStyle.Flat;
            digitButton_3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            digitButton_3.ForeColor = SystemColors.ControlDarkDark;
            digitButton_3.Location = new Point(135, 237);
            digitButton_3.Name = "digitButton_3";
            digitButton_3.Size = new Size(45, 45);
            digitButton_3.TabIndex = 15;
            digitButton_3.Text = "3";
            digitButton_3.UseVisualStyleBackColor = true;
            // 
            // digitButton_2
            // 
            digitButton_2.BackgroundImage = Properties.Resources.button_background_image;
            digitButton_2.FlatAppearance.BorderSize = 0;
            digitButton_2.FlatStyle = FlatStyle.Flat;
            digitButton_2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            digitButton_2.ForeColor = SystemColors.ControlDarkDark;
            digitButton_2.Location = new Point(84, 237);
            digitButton_2.Name = "digitButton_2";
            digitButton_2.Size = new Size(45, 45);
            digitButton_2.TabIndex = 14;
            digitButton_2.Text = "2";
            digitButton_2.UseVisualStyleBackColor = true;
            // 
            // digitButton_1
            // 
            digitButton_1.BackgroundImage = Properties.Resources.button_background_image;
            digitButton_1.FlatAppearance.BorderSize = 0;
            digitButton_1.FlatStyle = FlatStyle.Flat;
            digitButton_1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            digitButton_1.ForeColor = SystemColors.ControlDarkDark;
            digitButton_1.Location = new Point(33, 237);
            digitButton_1.Name = "digitButton_1";
            digitButton_1.Size = new Size(45, 45);
            digitButton_1.TabIndex = 13;
            digitButton_1.Text = "1";
            digitButton_1.UseVisualStyleBackColor = true;
            // 
            // showResultButton
            // 
            showResultButton.BackgroundImage = Properties.Resources.button_background_image;
            showResultButton.FlatAppearance.BorderSize = 0;
            showResultButton.FlatStyle = FlatStyle.Flat;
            showResultButton.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            showResultButton.ForeColor = SystemColors.ControlDarkDark;
            showResultButton.Location = new Point(135, 288);
            showResultButton.Name = "showResultButton";
            showResultButton.Size = new Size(45, 45);
            showResultButton.TabIndex = 18;
            showResultButton.Text = "=";
            showResultButton.UseVisualStyleBackColor = true;
            // 
            // digitButton_0
            // 
            digitButton_0.BackgroundImage = Properties.Resources.button_background_image;
            digitButton_0.FlatAppearance.BorderSize = 0;
            digitButton_0.FlatStyle = FlatStyle.Flat;
            digitButton_0.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            digitButton_0.ForeColor = SystemColors.ControlDarkDark;
            digitButton_0.Location = new Point(84, 288);
            digitButton_0.Name = "digitButton_0";
            digitButton_0.Size = new Size(45, 45);
            digitButton_0.TabIndex = 17;
            digitButton_0.Text = "0";
            digitButton_0.UseVisualStyleBackColor = true;
            // 
            // separatorButton
            // 
            separatorButton.BackgroundImage = Properties.Resources.button_background_image;
            separatorButton.FlatAppearance.BorderSize = 0;
            separatorButton.FlatStyle = FlatStyle.Flat;
            separatorButton.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
            separatorButton.ForeColor = SystemColors.ControlDarkDark;
            separatorButton.ImageAlign = ContentAlignment.MiddleRight;
            separatorButton.Location = new Point(33, 288);
            separatorButton.Name = "separatorButton";
            separatorButton.Size = new Size(45, 45);
            separatorButton.TabIndex = 16;
            separatorButton.Text = ".";
            separatorButton.TextAlign = ContentAlignment.TopCenter;
            separatorButton.UseVisualStyleBackColor = true;
            // 
            // operationButton_add
            // 
            operationButton_add.BackgroundImage = Properties.Resources.button_background_image;
            operationButton_add.FlatAppearance.BorderSize = 0;
            operationButton_add.FlatStyle = FlatStyle.Flat;
            operationButton_add.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            operationButton_add.ForeColor = SystemColors.ControlDarkDark;
            operationButton_add.Location = new Point(186, 135);
            operationButton_add.Name = "operationButton_add";
            operationButton_add.Size = new Size(45, 45);
            operationButton_add.TabIndex = 19;
            operationButton_add.Text = "+";
            operationButton_add.UseVisualStyleBackColor = true;
            // 
            // operationButton_substract
            // 
            operationButton_substract.BackgroundImage = Properties.Resources.button_background_image;
            operationButton_substract.FlatAppearance.BorderSize = 0;
            operationButton_substract.FlatStyle = FlatStyle.Flat;
            operationButton_substract.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
            operationButton_substract.ForeColor = SystemColors.ControlDarkDark;
            operationButton_substract.Location = new Point(186, 186);
            operationButton_substract.Name = "operationButton_substract";
            operationButton_substract.Size = new Size(45, 45);
            operationButton_substract.TabIndex = 20;
            operationButton_substract.Text = "-";
            operationButton_substract.UseVisualStyleBackColor = true;
            // 
            // operationButton_multiply
            // 
            operationButton_multiply.BackgroundImage = Properties.Resources.button_background_image;
            operationButton_multiply.FlatAppearance.BorderSize = 0;
            operationButton_multiply.FlatStyle = FlatStyle.Flat;
            operationButton_multiply.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            operationButton_multiply.ForeColor = SystemColors.ControlDarkDark;
            operationButton_multiply.Location = new Point(186, 237);
            operationButton_multiply.Name = "operationButton_multiply";
            operationButton_multiply.Size = new Size(45, 45);
            operationButton_multiply.TabIndex = 21;
            operationButton_multiply.Text = "*";
            operationButton_multiply.UseVisualStyleBackColor = true;
            // 
            // operationButton_divide
            // 
            operationButton_divide.BackgroundImage = Properties.Resources.button_background_image;
            operationButton_divide.FlatAppearance.BorderSize = 0;
            operationButton_divide.FlatStyle = FlatStyle.Flat;
            operationButton_divide.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            operationButton_divide.ForeColor = SystemColors.ControlDarkDark;
            operationButton_divide.Location = new Point(186, 288);
            operationButton_divide.Name = "operationButton_divide";
            operationButton_divide.Size = new Size(45, 45);
            operationButton_divide.TabIndex = 22;
            operationButton_divide.Text = "/";
            operationButton_divide.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(265, 366);
            Controls.Add(operationButton_divide);
            Controls.Add(operationButton_multiply);
            Controls.Add(operationButton_substract);
            Controls.Add(operationButton_add);
            Controls.Add(showResultButton);
            Controls.Add(digitButton_0);
            Controls.Add(separatorButton);
            Controls.Add(digitButton_3);
            Controls.Add(digitButton_2);
            Controls.Add(digitButton_1);
            Controls.Add(digitButton_6);
            Controls.Add(digitButton_5);
            Controls.Add(digitButton_4);
            Controls.Add(digitButton_9);
            Controls.Add(digitButton_8);
            Controls.Add(digitButton_7);
            Controls.Add(closingBracketButton);
            Controls.Add(openingBracketButton);
            Controls.Add(backspaceButton);
            Controls.Add(clearButton);
            Controls.Add(resultTextBox);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox resultTextBox;
        private Button clearButton;
        private PictureBox pictureBox1;
        private Button backspaceButton;
        private Button openingBracketButton;
        private Button closingBracketButton;
        private Button digitButton_8;
        private Button digitButton_7;
        private Button digitButton_9;
        private Button digitButton_6;
        private Button digitButton_5;
        private Button digitButton_4;
        private Button digitButton_3;
        private Button digitButton_2;
        private Button digitButton_1;
        private Button showResultButton;
        private Button digitButton_0;
        private Button separatorButton;
        private Button operationButton_add;
        private Button operationButton_substract;
        private Button operationButton_multiply;
        private Button operationButton_divide;
    }
}