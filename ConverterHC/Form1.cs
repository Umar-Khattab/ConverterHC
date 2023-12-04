using System.Security.Policy;
using System.Threading;
using System;

namespace ConverterHC
{
    public partial class Form1 : Form
    {
        int Result;
        //combonents
        private Button One;
        private TextBox Output;
        private Button Nine;
        private Button Six;
        private Button Three;
        private Button Eight;
        private Button Five;
        private Button Seven;
        private Button Four;
        private Button Two;
        private Button Zero;
        private Button ToBinary;
        private Button ToDecimal;
        private Button Equal;
        private Button AC;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            One = new Button();
            Output = new TextBox();
            Nine = new Button();
            Six = new Button();
            Three = new Button();
            Eight = new Button();
            Five = new Button();
            Seven = new Button();
            Four = new Button();
            Two = new Button();
            Zero = new Button();
            ToBinary = new Button();
            ToDecimal = new Button();
            Equal = new Button();
            AC = new Button();
            SuspendLayout();
            // 
            // One
            // 
            One.BackColor = Color.FromArgb(64, 64, 64);
            One.FlatStyle = FlatStyle.Popup;
            One.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            One.ForeColor = SystemColors.ControlLightLight;
            One.Location = new Point(12, 252);
            One.Name = "One";
            One.Size = new Size(73, 67);
            One.TabIndex = 0;
            One.Text = "1";
            One.UseVisualStyleBackColor = false;
            One.Click += EnterNumbers;
            // 
            // Output
            // 
            Output.BackColor = Color.Black;
            Output.BorderStyle = BorderStyle.None;
            Output.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Output.ForeColor = SystemColors.Window;
            Output.Location = new Point(12, 22);
            Output.Multiline = true;
            Output.Name = "Output";
            Output.ReadOnly = true;
            Output.RightToLeft = RightToLeft.Yes;
            Output.Size = new Size(290, 68);
            Output.TabIndex = 1;
            Output.Text = "0";
            // 
            // Nine
            // 
            Nine.BackColor = Color.FromArgb(64, 64, 64);
            Nine.FlatStyle = FlatStyle.Popup;
            Nine.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Nine.ForeColor = SystemColors.ControlLightLight;
            Nine.Location = new Point(168, 105);
            Nine.Name = "Nine";
            Nine.Size = new Size(73, 67);
            Nine.TabIndex = 2;
            Nine.Text = "9";
            Nine.UseVisualStyleBackColor = false;
            Nine.Click += EnterNumbers;
            // 
            // Six
            // 
            Six.BackColor = Color.FromArgb(64, 64, 64);
            Six.FlatStyle = FlatStyle.Popup;
            Six.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Six.ForeColor = SystemColors.ControlLightLight;
            Six.Location = new Point(168, 178);
            Six.Name = "Six";
            Six.Size = new Size(73, 67);
            Six.TabIndex = 3;
            Six.Text = "6";
            Six.UseVisualStyleBackColor = false;
            Six.Click += EnterNumbers;
            // 
            // Three
            // 
            Three.BackColor = Color.FromArgb(64, 64, 64);
            Three.FlatStyle = FlatStyle.Popup;
            Three.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Three.ForeColor = SystemColors.ControlLightLight;
            Three.Location = new Point(168, 251);
            Three.Name = "Three";
            Three.Size = new Size(73, 67);
            Three.TabIndex = 5;
            Three.Text = "3";
            Three.UseVisualStyleBackColor = false;
            Three.Click += EnterNumbers;
            // 
            // Eight
            // 
            Eight.BackColor = Color.FromArgb(64, 64, 64);
            Eight.FlatStyle = FlatStyle.Popup;
            Eight.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Eight.ForeColor = SystemColors.ControlLightLight;
            Eight.Location = new Point(89, 105);
            Eight.Name = "Eight";
            Eight.Size = new Size(75, 67);
            Eight.TabIndex = 6;
            Eight.Text = "8";
            Eight.UseVisualStyleBackColor = false;
            Eight.Click += EnterNumbers;
            // 
            // Five
            // 
            Five.BackColor = Color.FromArgb(64, 64, 64);
            Five.FlatStyle = FlatStyle.Popup;
            Five.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Five.ForeColor = SystemColors.ControlLightLight;
            Five.Location = new Point(91, 178);
            Five.Name = "Five";
            Five.Size = new Size(73, 67);
            Five.TabIndex = 7;
            Five.Text = "5";
            Five.UseVisualStyleBackColor = false;
            Five.Click += EnterNumbers;
            // 
            // Seven
            // 
            Seven.BackColor = Color.FromArgb(64, 64, 64);
            Seven.FlatStyle = FlatStyle.Popup;
            Seven.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Seven.ForeColor = SystemColors.ControlLightLight;
            Seven.Location = new Point(12, 105);
            Seven.Name = "Seven";
            Seven.Size = new Size(73, 67);
            Seven.TabIndex = 8;
            Seven.Text = "7";
            Seven.UseVisualStyleBackColor = false;
            Seven.Click += EnterNumbers;
            // 
            // Four
            // 
            Four.BackColor = Color.FromArgb(64, 64, 64);
            Four.FlatStyle = FlatStyle.Popup;
            Four.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Four.ForeColor = SystemColors.ControlLightLight;
            Four.Location = new Point(12, 178);
            Four.Name = "Four";
            Four.Size = new Size(73, 67);
            Four.TabIndex = 9;
            Four.Text = "4";
            Four.UseVisualStyleBackColor = false;
            Four.Click += EnterNumbers;
            // 
            // Two
            // 
            Two.BackColor = Color.FromArgb(64, 64, 64);
            Two.FlatStyle = FlatStyle.Popup;
            Two.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Two.ForeColor = SystemColors.ControlLightLight;
            Two.Location = new Point(89, 252);
            Two.Name = "Two";
            Two.Size = new Size(73, 67);
            Two.TabIndex = 10;
            Two.Text = "2";
            Two.UseVisualStyleBackColor = false;
            Two.Click += EnterNumbers;
            // 
            // Zero
            // 
            Zero.BackColor = Color.Gray;
            Zero.FlatStyle = FlatStyle.Popup;
            Zero.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Zero.ForeColor = SystemColors.ControlLightLight;
            Zero.Location = new Point(12, 325);
            Zero.Name = "Zero";
            Zero.Size = new Size(229, 67);
            Zero.TabIndex = 11;
            Zero.Text = "0";
            Zero.UseVisualStyleBackColor = false;
            Zero.Click += EnterNumbers;
            // 
            // ToBinary
            // 
            ToBinary.BackColor = Color.OrangeRed;
            ToBinary.FlatStyle = FlatStyle.Popup;
            ToBinary.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            ToBinary.ForeColor = SystemColors.ControlLightLight;
            ToBinary.Location = new Point(247, 178);
            ToBinary.Name = "ToBinary";
            ToBinary.Size = new Size(71, 103);
            ToBinary.TabIndex = 12;
            ToBinary.Text = "To\r\nBin";
            ToBinary.UseVisualStyleBackColor = false;
            ToBinary.Click += ToBinary_Click;
            // 
            // ToDecimal
            // 
            ToDecimal.BackColor = Color.OrangeRed;
            ToDecimal.FlatStyle = FlatStyle.Popup;
            ToDecimal.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            ToDecimal.ForeColor = SystemColors.ControlLightLight;
            ToDecimal.Location = new Point(247, 287);
            ToDecimal.Name = "ToDecimal";
            ToDecimal.Size = new Size(71, 105);
            ToDecimal.TabIndex = 13;
            ToDecimal.Text = "To\r\nDeci";
            ToDecimal.UseVisualStyleBackColor = false;
            ToDecimal.Click += ToDecimal_Click;
            // 
            // Equal
            // 
            Equal.Location = new Point(0, 0);
            Equal.Name = "Equal";
            Equal.Size = new Size(75, 23);
            Equal.TabIndex = 0;
            // 
            // AC
            // 
            AC.BackColor = Color.OrangeRed;
            AC.FlatStyle = FlatStyle.Popup;
            AC.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            AC.ForeColor = SystemColors.ControlLightLight;
            AC.Location = new Point(247, 105);
            AC.Name = "AC";
            AC.Size = new Size(71, 67);
            AC.TabIndex = 14;
            AC.Text = "AC";
            AC.UseVisualStyleBackColor = false;
            AC.Click += AC_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(334, 407);
            Controls.Add(AC);
            Controls.Add(ToDecimal);
            Controls.Add(ToBinary);
            Controls.Add(Zero);
            Controls.Add(Two);
            Controls.Add(Four);
            Controls.Add(Seven);
            Controls.Add(Five);
            Controls.Add(Eight);
            Controls.Add(Three);
            Controls.Add(Six);
            Controls.Add(Nine);
            Controls.Add(Output);
            Controls.Add(One);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }
        private void EnterNumbers(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            if (Output.Text == "0")
            {
                Output.Text = "";
            }
            Output.Text += number.Text;
        }
        private void ToDecimal_Click(object sender, EventArgs e)
        {
            Output.Text = ConvertToDecimal();
        }
        private void ToBinary_Click(object sender, EventArgs e)
        {
            Output.Text = ConvertToBinary();
        }
        public string ConvertToBinary()
        {
            Result = int.Parse(Output.Text);
            string s = "";
            Stack BinaryStack = new Stack();
            while (Result != 0)
            {
                BinaryStack.Push(Result % 2);
                Result = Result / 2;
            }
            while (!BinaryStack.IsEmpty())
            {
                s = s + BinaryStack.pop();
            }
            return s;
        }
        public string ConvertToDecimal()
        {
            Stack DecimalStack = new Stack();
            string Input = Output.Text;
            foreach (char Digit in Input)
            {
                int bit = int.Parse(Digit.ToString());
                DecimalStack.Push(bit);
            }
            Result = 0;
            int Power = 0;
            while (DecimalStack.Size() > 0)
            {
                int bit = DecimalStack.pop();
                Result += bit * (int)Math.Pow(2, Power);
                Power++;
            }
            return Result.ToString();
        }

        private void AC_Click(object sender, EventArgs e)
        {
            Output.Text = "0";
            Result = 0;
        }
    }
}