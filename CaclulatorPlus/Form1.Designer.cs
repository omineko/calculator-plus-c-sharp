namespace CaclulatorPlus
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.formTitle = new System.Windows.Forms.Label();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.showHistoryBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.expressionPreview = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.currentValue = new System.Windows.Forms.Label();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.substract = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.pi = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.raiseY = new System.Windows.Forms.Button();
            this.raiseTwo = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.round = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.clearAll = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.historyPanel = new System.Windows.Forms.Panel();
            this.history = new System.Windows.Forms.RichTextBox();
            this.clearHistory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.historyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.formTitle);
            this.panel1.Controls.Add(this.minimizeBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 30);
            this.panel1.TabIndex = 0;
            // 
            // formTitle
            // 
            this.formTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.formTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formTitle.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formTitle.ForeColor = System.Drawing.Color.White;
            this.formTitle.Location = new System.Drawing.Point(0, 0);
            this.formTitle.Margin = new System.Windows.Forms.Padding(0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.formTitle.Size = new System.Drawing.Size(136, 30);
            this.formTitle.TabIndex = 3;
            this.formTitle.Text = "Calculator Plus!";
            this.formTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.Location = new System.Drawing.Point(528, 0);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(40, 30);
            this.minimizeBtn.TabIndex = 2;
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.Button2_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(568, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 30);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // showHistoryBtn
            // 
            this.showHistoryBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.showHistoryBtn.FlatAppearance.BorderSize = 0;
            this.showHistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showHistoryBtn.Image = ((System.Drawing.Image)(resources.GetObject("showHistoryBtn.Image")));
            this.showHistoryBtn.Location = new System.Drawing.Point(568, 0);
            this.showHistoryBtn.Margin = new System.Windows.Forms.Padding(0);
            this.showHistoryBtn.Name = "showHistoryBtn";
            this.showHistoryBtn.Size = new System.Drawing.Size(40, 30);
            this.showHistoryBtn.TabIndex = 3;
            this.showHistoryBtn.UseVisualStyleBackColor = true;
            this.showHistoryBtn.Click += new System.EventHandler(this.ShowHistoryBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.showHistoryBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 30);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.expressionPreview);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 30);
            this.panel3.TabIndex = 5;
            // 
            // expressionPreview
            // 
            this.expressionPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expressionPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expressionPreview.ForeColor = System.Drawing.Color.DarkGray;
            this.expressionPreview.Location = new System.Drawing.Point(0, 0);
            this.expressionPreview.Margin = new System.Windows.Forms.Padding(0);
            this.expressionPreview.Name = "expressionPreview";
            this.expressionPreview.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.expressionPreview.Size = new System.Drawing.Size(608, 30);
            this.expressionPreview.TabIndex = 4;
            this.expressionPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.currentValue);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 90);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(608, 50);
            this.panel4.TabIndex = 6;
            // 
            // currentValue
            // 
            this.currentValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentValue.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentValue.ForeColor = System.Drawing.Color.White;
            this.currentValue.Location = new System.Drawing.Point(0, 0);
            this.currentValue.Margin = new System.Windows.Forms.Padding(0);
            this.currentValue.Name = "currentValue";
            this.currentValue.Size = new System.Drawing.Size(608, 50);
            this.currentValue.TabIndex = 5;
            this.currentValue.Text = "0";
            this.currentValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.seven.FlatAppearance.BorderSize = 0;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.seven.ForeColor = System.Drawing.Color.White;
            this.seven.Location = new System.Drawing.Point(263, 178);
            this.seven.Margin = new System.Windows.Forms.Padding(0);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(80, 55);
            this.seven.TabIndex = 7;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.eight.FlatAppearance.BorderSize = 0;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eight.ForeColor = System.Drawing.Color.White;
            this.eight.Location = new System.Drawing.Point(348, 178);
            this.eight.Margin = new System.Windows.Forms.Padding(0);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(80, 55);
            this.eight.TabIndex = 8;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.nine.FlatAppearance.BorderSize = 0;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nine.ForeColor = System.Drawing.Color.White;
            this.nine.Location = new System.Drawing.Point(433, 178);
            this.nine.Margin = new System.Windows.Forms.Padding(0);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(80, 55);
            this.nine.TabIndex = 9;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.six.FlatAppearance.BorderSize = 0;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.six.ForeColor = System.Drawing.Color.White;
            this.six.Location = new System.Drawing.Point(433, 238);
            this.six.Margin = new System.Windows.Forms.Padding(0);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(80, 55);
            this.six.TabIndex = 12;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.Six_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.five.FlatAppearance.BorderSize = 0;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.five.ForeColor = System.Drawing.Color.White;
            this.five.Location = new System.Drawing.Point(348, 238);
            this.five.Margin = new System.Windows.Forms.Padding(0);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(80, 55);
            this.five.TabIndex = 11;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.Five_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.four.FlatAppearance.BorderSize = 0;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.four.ForeColor = System.Drawing.Color.White;
            this.four.Location = new System.Drawing.Point(263, 238);
            this.four.Margin = new System.Windows.Forms.Padding(0);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(80, 55);
            this.four.TabIndex = 10;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.Four_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.three.FlatAppearance.BorderSize = 0;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.three.ForeColor = System.Drawing.Color.White;
            this.three.Location = new System.Drawing.Point(433, 298);
            this.three.Margin = new System.Windows.Forms.Padding(0);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(80, 55);
            this.three.TabIndex = 15;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.Three_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.two.FlatAppearance.BorderSize = 0;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.two.ForeColor = System.Drawing.Color.White;
            this.two.Location = new System.Drawing.Point(348, 298);
            this.two.Margin = new System.Windows.Forms.Padding(0);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(80, 55);
            this.two.TabIndex = 14;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.Two_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.one.FlatAppearance.BorderSize = 0;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.one.ForeColor = System.Drawing.Color.White;
            this.one.Location = new System.Drawing.Point(263, 298);
            this.one.Margin = new System.Windows.Forms.Padding(0);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(80, 55);
            this.one.TabIndex = 13;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.One_Click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.equals.FlatAppearance.BorderSize = 0;
            this.equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equals.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.equals.ForeColor = System.Drawing.Color.White;
            this.equals.Location = new System.Drawing.Point(433, 358);
            this.equals.Margin = new System.Windows.Forms.Padding(0);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(80, 55);
            this.equals.TabIndex = 18;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.zero.FlatAppearance.BorderSize = 0;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zero.ForeColor = System.Drawing.Color.White;
            this.zero.Location = new System.Drawing.Point(348, 358);
            this.zero.Margin = new System.Windows.Forms.Padding(0);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(80, 55);
            this.zero.TabIndex = 17;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.dot.FlatAppearance.BorderSize = 0;
            this.dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dot.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dot.ForeColor = System.Drawing.Color.White;
            this.dot.Location = new System.Drawing.Point(263, 358);
            this.dot.Margin = new System.Windows.Forms.Padding(0);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(80, 55);
            this.dot.TabIndex = 16;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(517, 178);
            this.add.Margin = new System.Windows.Forms.Padding(0);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(80, 55);
            this.add.TabIndex = 19;
            this.add.Text = "＋";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // substract
            // 
            this.substract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.substract.FlatAppearance.BorderSize = 0;
            this.substract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.substract.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.substract.ForeColor = System.Drawing.Color.White;
            this.substract.Location = new System.Drawing.Point(517, 238);
            this.substract.Margin = new System.Windows.Forms.Padding(0);
            this.substract.Name = "substract";
            this.substract.Size = new System.Drawing.Size(80, 55);
            this.substract.TabIndex = 20;
            this.substract.Text = "－";
            this.substract.UseVisualStyleBackColor = false;
            this.substract.Click += new System.EventHandler(this.Substract_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.divide.FlatAppearance.BorderSize = 0;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.divide.ForeColor = System.Drawing.Color.White;
            this.divide.Location = new System.Drawing.Point(517, 298);
            this.divide.Margin = new System.Windows.Forms.Padding(0);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(80, 55);
            this.divide.TabIndex = 21;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.multiply.FlatAppearance.BorderSize = 0;
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiply.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.multiply.ForeColor = System.Drawing.Color.White;
            this.multiply.Location = new System.Drawing.Point(517, 358);
            this.multiply.Margin = new System.Windows.Forms.Padding(0);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(80, 55);
            this.multiply.TabIndex = 22;
            this.multiply.Text = "×";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // tan
            // 
            this.tan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.tan.FlatAppearance.BorderSize = 0;
            this.tan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tan.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tan.ForeColor = System.Drawing.Color.White;
            this.tan.Location = new System.Drawing.Point(178, 178);
            this.tan.Margin = new System.Windows.Forms.Padding(0);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(80, 55);
            this.tan.TabIndex = 25;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = false;
            this.tan.Click += new System.EventHandler(this.Tan_Click);
            // 
            // cos
            // 
            this.cos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cos.FlatAppearance.BorderSize = 0;
            this.cos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cos.ForeColor = System.Drawing.Color.White;
            this.cos.Location = new System.Drawing.Point(93, 178);
            this.cos.Margin = new System.Windows.Forms.Padding(0);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(80, 55);
            this.cos.TabIndex = 24;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = false;
            this.cos.Click += new System.EventHandler(this.Cos_Click);
            // 
            // sin
            // 
            this.sin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.sin.FlatAppearance.BorderSize = 0;
            this.sin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sin.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sin.ForeColor = System.Drawing.Color.White;
            this.sin.Location = new System.Drawing.Point(8, 178);
            this.sin.Margin = new System.Windows.Forms.Padding(0);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(80, 55);
            this.sin.TabIndex = 23;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = false;
            this.sin.Click += new System.EventHandler(this.Sin_Click);
            // 
            // pi
            // 
            this.pi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pi.FlatAppearance.BorderSize = 0;
            this.pi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pi.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pi.ForeColor = System.Drawing.Color.White;
            this.pi.Location = new System.Drawing.Point(178, 238);
            this.pi.Margin = new System.Windows.Forms.Padding(0);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(80, 55);
            this.pi.TabIndex = 28;
            this.pi.Text = "π";
            this.pi.UseVisualStyleBackColor = false;
            this.pi.Click += new System.EventHandler(this.Pi_Click);
            // 
            // mod
            // 
            this.mod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.mod.FlatAppearance.BorderSize = 0;
            this.mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mod.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mod.ForeColor = System.Drawing.Color.White;
            this.mod.Location = new System.Drawing.Point(93, 238);
            this.mod.Margin = new System.Windows.Forms.Padding(0);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(80, 55);
            this.mod.TabIndex = 27;
            this.mod.Text = "Mod";
            this.mod.UseVisualStyleBackColor = false;
            this.mod.Click += new System.EventHandler(this.Mod_Click);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.log.FlatAppearance.BorderSize = 0;
            this.log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.log.ForeColor = System.Drawing.Color.White;
            this.log.Location = new System.Drawing.Point(8, 238);
            this.log.Margin = new System.Windows.Forms.Padding(0);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(80, 55);
            this.log.TabIndex = 26;
            this.log.Text = "log";
            this.log.UseVisualStyleBackColor = false;
            this.log.Click += new System.EventHandler(this.Log_Click);
            // 
            // raiseY
            // 
            this.raiseY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.raiseY.FlatAppearance.BorderSize = 0;
            this.raiseY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raiseY.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raiseY.ForeColor = System.Drawing.Color.White;
            this.raiseY.Location = new System.Drawing.Point(178, 298);
            this.raiseY.Margin = new System.Windows.Forms.Padding(0);
            this.raiseY.Name = "raiseY";
            this.raiseY.Size = new System.Drawing.Size(80, 55);
            this.raiseY.TabIndex = 31;
            this.raiseY.Text = "xʸ";
            this.raiseY.UseVisualStyleBackColor = false;
            this.raiseY.Click += new System.EventHandler(this.RaiseY_Click);
            // 
            // raiseTwo
            // 
            this.raiseTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.raiseTwo.FlatAppearance.BorderSize = 0;
            this.raiseTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raiseTwo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.raiseTwo.ForeColor = System.Drawing.Color.White;
            this.raiseTwo.Location = new System.Drawing.Point(93, 298);
            this.raiseTwo.Margin = new System.Windows.Forms.Padding(0);
            this.raiseTwo.Name = "raiseTwo";
            this.raiseTwo.Size = new System.Drawing.Size(80, 55);
            this.raiseTwo.TabIndex = 30;
            this.raiseTwo.Text = "x²";
            this.raiseTwo.UseVisualStyleBackColor = false;
            this.raiseTwo.Click += new System.EventHandler(this.RaiseTwo_Click);
            // 
            // root
            // 
            this.root.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.root.FlatAppearance.BorderSize = 0;
            this.root.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.root.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.root.ForeColor = System.Drawing.Color.White;
            this.root.Location = new System.Drawing.Point(8, 298);
            this.root.Margin = new System.Windows.Forms.Padding(0);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(80, 55);
            this.root.TabIndex = 29;
            this.root.Text = "√";
            this.root.UseVisualStyleBackColor = false;
            this.root.Click += new System.EventHandler(this.Root_Click);
            // 
            // factorial
            // 
            this.factorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.factorial.FlatAppearance.BorderSize = 0;
            this.factorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.factorial.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.factorial.ForeColor = System.Drawing.Color.White;
            this.factorial.Location = new System.Drawing.Point(178, 358);
            this.factorial.Margin = new System.Windows.Forms.Padding(0);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(80, 55);
            this.factorial.TabIndex = 34;
            this.factorial.Text = "n!";
            this.factorial.UseVisualStyleBackColor = false;
            this.factorial.Click += new System.EventHandler(this.Factorial_Click);
            // 
            // round
            // 
            this.round.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.round.FlatAppearance.BorderSize = 0;
            this.round.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.round.ForeColor = System.Drawing.Color.White;
            this.round.Location = new System.Drawing.Point(93, 358);
            this.round.Margin = new System.Windows.Forms.Padding(0);
            this.round.Name = "round";
            this.round.Size = new System.Drawing.Size(80, 55);
            this.round.TabIndex = 33;
            this.round.Text = "Round";
            this.round.UseVisualStyleBackColor = false;
            this.round.Click += new System.EventHandler(this.Round_Click);
            // 
            // exp
            // 
            this.exp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.exp.FlatAppearance.BorderSize = 0;
            this.exp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exp.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exp.ForeColor = System.Drawing.Color.White;
            this.exp.Location = new System.Drawing.Point(8, 358);
            this.exp.Margin = new System.Windows.Forms.Padding(0);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(80, 55);
            this.exp.TabIndex = 32;
            this.exp.Text = "Exp";
            this.exp.UseVisualStyleBackColor = false;
            this.exp.Click += new System.EventHandler(this.Exp_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.clearAll);
            this.panel5.Controls.Add(this.clear);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 140);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(608, 30);
            this.panel5.TabIndex = 35;
            // 
            // clearAll
            // 
            this.clearAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.clearAll.FlatAppearance.BorderSize = 0;
            this.clearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAll.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearAll.ForeColor = System.Drawing.Color.White;
            this.clearAll.Location = new System.Drawing.Point(528, 0);
            this.clearAll.Margin = new System.Windows.Forms.Padding(0);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(40, 30);
            this.clearAll.TabIndex = 4;
            this.clearAll.Text = "C";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // clear
            // 
            this.clear.Dock = System.Windows.Forms.DockStyle.Right;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Image = ((System.Drawing.Image)(resources.GetObject("clear.Image")));
            this.clear.Location = new System.Drawing.Point(568, 0);
            this.clear.Margin = new System.Windows.Forms.Padding(0);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(40, 30);
            this.clear.TabIndex = 3;
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // historyPanel
            // 
            this.historyPanel.Controls.Add(this.history);
            this.historyPanel.Controls.Add(this.clearHistory);
            this.historyPanel.Location = new System.Drawing.Point(0, 178);
            this.historyPanel.Name = "historyPanel";
            this.historyPanel.Size = new System.Drawing.Size(608, 0);
            this.historyPanel.TabIndex = 36;
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.history.ForeColor = System.Drawing.Color.White;
            this.history.Location = new System.Drawing.Point(0, 0);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(608, 0);
            this.history.TabIndex = 6;
            this.history.Text = "";
            // 
            // clearHistory
            // 
            this.clearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clearHistory.FlatAppearance.BorderSize = 0;
            this.clearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearHistory.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearHistory.ForeColor = System.Drawing.Color.White;
            this.clearHistory.Location = new System.Drawing.Point(0, -30);
            this.clearHistory.Margin = new System.Windows.Forms.Padding(0);
            this.clearHistory.Name = "clearHistory";
            this.clearHistory.Size = new System.Drawing.Size(608, 30);
            this.clearHistory.TabIndex = 5;
            this.clearHistory.Text = "Clear History";
            this.clearHistory.UseVisualStyleBackColor = true;
            this.clearHistory.Click += new System.EventHandler(this.ClearHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(608, 421);
            this.Controls.Add(this.historyPanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.factorial);
            this.Controls.Add(this.round);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.raiseY);
            this.Controls.Add(this.raiseTwo);
            this.Controls.Add(this.root);
            this.Controls.Add(this.pi);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.log);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.substract);
            this.Controls.Add(this.add);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.historyPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button closeBtn;
        private Button minimizeBtn;
        private Label formTitle;
        private Button showHistoryBtn;
        private Panel panel2;
        private Panel panel3;
        private Label expressionPreview;
        private Panel panel4;
        private Label currentValue;
        private Button seven;
        private Button eight;
        private Button nine;
        private Button six;
        private Button five;
        private Button four;
        private Button three;
        private Button two;
        private Button one;
        private Button equals;
        private Button zero;
        private Button dot;
        private Button add;
        private Button substract;
        private Button divide;
        private Button multiply;
        private Button tan;
        private Button cos;
        private Button sin;
        private Button pi;
        private Button mod;
        private Button log;
        private Button raiseY;
        private Button raiseTwo;
        private Button root;
        private Button factorial;
        private Button round;
        private Button exp;
        private Panel panel5;
        private Button clearAll;
        private Button clear;
        private Panel historyPanel;
        private RichTextBox history;
        private Button clearHistory;
    }
}