namespace Calculator
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
            inputScreen = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnEquals = new Button();
            btnDecimal = new Button();
            btnZero = new Button();
            btnNegative = new Button();
            btnAdd = new Button();
            btnThree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            btnSubstract = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnMultiply = new Button();
            btnNine = new Button();
            btnEight = new Button();
            btnSeven = new Button();
            btnDivide = new Button();
            btnPercent = new Button();
            btnParenthesis = new Button();
            btnClear = new Button();
            outputScreen = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // inputScreen
            // 
            inputScreen.BackColor = SystemColors.MenuText;
            inputScreen.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            inputScreen.ForeColor = Color.Transparent;
            inputScreen.Location = new Point(12, 12);
            inputScreen.Multiline = true;
            inputScreen.Name = "inputScreen";
            inputScreen.Size = new Size(300, 45);
            inputScreen.TabIndex = 0;
            inputScreen.TextChanged += textBox1_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnEquals, 3, 4);
            tableLayoutPanel1.Controls.Add(btnDecimal, 2, 4);
            tableLayoutPanel1.Controls.Add(btnZero, 1, 4);
            tableLayoutPanel1.Controls.Add(btnNegative, 0, 4);
            tableLayoutPanel1.Controls.Add(btnAdd, 3, 3);
            tableLayoutPanel1.Controls.Add(btnThree, 2, 3);
            tableLayoutPanel1.Controls.Add(btnTwo, 1, 3);
            tableLayoutPanel1.Controls.Add(btnOne, 0, 3);
            tableLayoutPanel1.Controls.Add(btnSubstract, 3, 2);
            tableLayoutPanel1.Controls.Add(btnSix, 2, 2);
            tableLayoutPanel1.Controls.Add(btnFive, 1, 2);
            tableLayoutPanel1.Controls.Add(btnFour, 0, 2);
            tableLayoutPanel1.Controls.Add(btnMultiply, 3, 1);
            tableLayoutPanel1.Controls.Add(btnNine, 2, 1);
            tableLayoutPanel1.Controls.Add(btnEight, 1, 1);
            tableLayoutPanel1.Controls.Add(btnSeven, 0, 1);
            tableLayoutPanel1.Controls.Add(btnDivide, 3, 0);
            tableLayoutPanel1.Controls.Add(btnPercent, 2, 0);
            tableLayoutPanel1.Controls.Add(btnParenthesis, 1, 0);
            tableLayoutPanel1.Controls.Add(btnClear, 0, 0);
            tableLayoutPanel1.ForeColor = Color.LawnGreen;
            tableLayoutPanel1.Location = new Point(12, 115);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(300, 445);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = SystemColors.WindowFrame;
            btnEquals.FlatAppearance.BorderColor = Color.Black;
            btnEquals.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEquals.ForeColor = Color.Orange;
            btnEquals.Location = new Point(228, 359);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(69, 83);
            btnEquals.TabIndex = 19;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = SystemColors.WindowFrame;
            btnDecimal.FlatAppearance.BorderColor = Color.Black;
            btnDecimal.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDecimal.ForeColor = Color.Ivory;
            btnDecimal.Location = new Point(153, 359);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(69, 83);
            btnDecimal.TabIndex = 18;
            btnDecimal.Text = ",";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = SystemColors.WindowFrame;
            btnZero.FlatAppearance.BorderColor = Color.Black;
            btnZero.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnZero.ForeColor = Color.Ivory;
            btnZero.Location = new Point(78, 359);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(69, 83);
            btnZero.TabIndex = 17;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            // 
            // btnNegative
            // 
            btnNegative.BackColor = SystemColors.WindowFrame;
            btnNegative.FlatAppearance.BorderColor = Color.Black;
            btnNegative.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNegative.ForeColor = Color.Ivory;
            btnNegative.Location = new Point(3, 359);
            btnNegative.Name = "btnNegative";
            btnNegative.Size = new Size(69, 83);
            btnNegative.TabIndex = 16;
            btnNegative.Text = "+/-";
            btnNegative.UseVisualStyleBackColor = false;
            btnNegative.Click += btnNegative_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.WindowFrame;
            btnAdd.FlatAppearance.BorderColor = Color.Black;
            btnAdd.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.LawnGreen;
            btnAdd.Location = new Point(228, 270);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(69, 83);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnThree
            // 
            btnThree.BackColor = SystemColors.WindowFrame;
            btnThree.FlatAppearance.BorderColor = Color.Black;
            btnThree.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnThree.ForeColor = Color.Ivory;
            btnThree.Location = new Point(153, 270);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(69, 83);
            btnThree.TabIndex = 14;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = false;
            btnThree.Click += btnThree_Click;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = SystemColors.WindowFrame;
            btnTwo.FlatAppearance.BorderColor = Color.Black;
            btnTwo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTwo.ForeColor = Color.Ivory;
            btnTwo.Location = new Point(78, 270);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(69, 83);
            btnTwo.TabIndex = 13;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnOne
            // 
            btnOne.BackColor = SystemColors.WindowFrame;
            btnOne.FlatAppearance.BorderColor = Color.Black;
            btnOne.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOne.ForeColor = Color.Ivory;
            btnOne.Location = new Point(3, 270);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(69, 83);
            btnOne.TabIndex = 12;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += btnOne_Click;
            // 
            // btnSubstract
            // 
            btnSubstract.BackColor = SystemColors.WindowFrame;
            btnSubstract.FlatAppearance.BorderColor = Color.Black;
            btnSubstract.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubstract.ForeColor = Color.LawnGreen;
            btnSubstract.Location = new Point(228, 181);
            btnSubstract.Name = "btnSubstract";
            btnSubstract.Size = new Size(69, 83);
            btnSubstract.TabIndex = 11;
            btnSubstract.Text = "-";
            btnSubstract.UseVisualStyleBackColor = false;
            btnSubstract.Click += btnSubstract_Click;
            // 
            // btnSix
            // 
            btnSix.BackColor = SystemColors.WindowFrame;
            btnSix.FlatAppearance.BorderColor = Color.Black;
            btnSix.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSix.ForeColor = Color.Ivory;
            btnSix.Location = new Point(153, 181);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(69, 83);
            btnSix.TabIndex = 10;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = false;
            btnSix.Click += btnSix_Click;
            // 
            // btnFive
            // 
            btnFive.BackColor = SystemColors.WindowFrame;
            btnFive.FlatAppearance.BorderColor = Color.Black;
            btnFive.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFive.ForeColor = Color.Ivory;
            btnFive.Location = new Point(78, 181);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(69, 83);
            btnFive.TabIndex = 9;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = false;
            btnFive.Click += btnFive_Click;
            // 
            // btnFour
            // 
            btnFour.BackColor = SystemColors.WindowFrame;
            btnFour.FlatAppearance.BorderColor = Color.Black;
            btnFour.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFour.ForeColor = Color.Ivory;
            btnFour.Location = new Point(3, 181);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(69, 83);
            btnFour.TabIndex = 8;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = false;
            btnFour.Click += btnFour_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = SystemColors.WindowFrame;
            btnMultiply.FlatAppearance.BorderColor = Color.Black;
            btnMultiply.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultiply.ForeColor = Color.LawnGreen;
            btnMultiply.Location = new Point(228, 92);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(69, 83);
            btnMultiply.TabIndex = 7;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnNine
            // 
            btnNine.BackColor = SystemColors.WindowFrame;
            btnNine.FlatAppearance.BorderColor = Color.Black;
            btnNine.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNine.ForeColor = Color.Ivory;
            btnNine.Location = new Point(153, 92);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(69, 83);
            btnNine.TabIndex = 6;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = false;
            btnNine.Click += btnNine_Click;
            // 
            // btnEight
            // 
            btnEight.BackColor = SystemColors.WindowFrame;
            btnEight.FlatAppearance.BorderColor = Color.Black;
            btnEight.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEight.ForeColor = Color.Ivory;
            btnEight.Location = new Point(78, 92);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(69, 83);
            btnEight.TabIndex = 5;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = false;
            btnEight.Click += btnEight_Click;
            // 
            // btnSeven
            // 
            btnSeven.BackColor = SystemColors.WindowFrame;
            btnSeven.FlatAppearance.BorderColor = Color.Black;
            btnSeven.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeven.ForeColor = Color.Ivory;
            btnSeven.Location = new Point(3, 92);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(69, 83);
            btnSeven.TabIndex = 4;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = false;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.WindowFrame;
            btnDivide.FlatAppearance.BorderColor = Color.Black;
            btnDivide.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivide.ForeColor = Color.LawnGreen;
            btnDivide.Location = new Point(228, 3);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(69, 83);
            btnDivide.TabIndex = 3;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnPercent
            // 
            btnPercent.BackColor = SystemColors.WindowFrame;
            btnPercent.FlatAppearance.BorderColor = Color.Black;
            btnPercent.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPercent.ForeColor = Color.LawnGreen;
            btnPercent.Location = new Point(153, 3);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(69, 83);
            btnPercent.TabIndex = 2;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            btnPercent.Click += btnPercent_Click;
            // 
            // btnParenthesis
            // 
            btnParenthesis.BackColor = SystemColors.WindowFrame;
            btnParenthesis.FlatAppearance.BorderColor = Color.Black;
            btnParenthesis.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnParenthesis.ForeColor = Color.LawnGreen;
            btnParenthesis.Location = new Point(78, 3);
            btnParenthesis.Name = "btnParenthesis";
            btnParenthesis.Size = new Size(69, 83);
            btnParenthesis.TabIndex = 1;
            btnParenthesis.Text = "()";
            btnParenthesis.UseVisualStyleBackColor = false;
            btnParenthesis.Click += btnParenthesis_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.WindowFrame;
            btnClear.FlatAppearance.BorderColor = Color.Black;
            btnClear.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = Color.Red;
            btnClear.Location = new Point(3, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(69, 83);
            btnClear.TabIndex = 0;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // outputScreen
            // 
            outputScreen.BackColor = SystemColors.MenuText;
            outputScreen.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            outputScreen.ForeColor = Color.Transparent;
            outputScreen.Location = new Point(12, 57);
            outputScreen.Multiline = true;
            outputScreen.Name = "outputScreen";
            outputScreen.Size = new Size(300, 51);
            outputScreen.TabIndex = 2;
            outputScreen.TextAlign = HorizontalAlignment.Right;
            outputScreen.TextChanged += outputScreen_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(324, 571);
            Controls.Add(outputScreen);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(inputScreen);
            MaximumSize = new Size(340, 610);
            MinimumSize = new Size(340, 610);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputScreen;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnClear;
        private Button btnEquals;
        private Button btnDecimal;
        private Button btnZero;
        private Button btnNegative;
        private Button btnAdd;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private Button btnSubstract;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnMultiply;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Button btnDivide;
        private Button btnPercent;
        private Button btnParenthesis;
        private TextBox outputScreen;
    }
}