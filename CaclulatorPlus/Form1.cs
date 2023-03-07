using CalculatorPlus;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace CaclulatorPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            Calculator.SetExpression(7);
            this.currentValue.Text = Calculator.GetExpression();
        }

        private void Five_Click(object sender, EventArgs e)
        {
            Calculator.SetExpression(5);
            this.currentValue.Text = Calculator.GetExpression();
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            Calculator.SetExpression(8);
            this.currentValue.Text = Calculator.GetExpression();
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            Calculator.SetExpression(9);
            this.currentValue.Text = Calculator.GetExpression();
        }

        private void Six_Click(object sender, EventArgs e)
        {
            Calculator.SetExpression(6);
            this.currentValue.Text = Calculator.GetExpression();
        }

        private void Three_Click(object sender, EventArgs e)
        {
            Calculator.SetExpression(3);
            this.currentValue.Text = Calculator.GetExpression();
        }

        private void Two_Click(object sender, EventArgs e)
        {
            Calculator.SetExpression(2);
            this.currentValue.Text = Calculator.GetExpression();
        }

        private void One_Click(object sender, EventArgs e)
        {
            Calculator.SetExpression(1);
            this.currentValue.Text = Calculator.GetExpression();
        }

        private void Four_Click(object sender, EventArgs e)
        {
            Calculator.SetExpression(4);
            this.currentValue.Text = Calculator.GetExpression();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            Calculator.SetExpression(0);
            this.currentValue.Text = Calculator.GetExpression();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Calculator.Remove();
            this.currentValue.Text = Calculator.GetExpression();
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            Calculator.Reset();
            this.currentValue.Text = Calculator.GetExpression();
            this.expressionPreview.Text = Calculator.GetPreview();
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            Calculator.InsertDecimalPoint();
            this.currentValue.Text = Calculator.GetExpression();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Calculator.Add();
            this.expressionPreview.Text = Calculator.GetPreview();
            this.currentValue.Text = Calculator.Calculate().ToString();
        }

        private void Substract_Click(object sender, EventArgs e)
        {
            Calculator.Subtract();
            this.expressionPreview.Text = Calculator.GetPreview();
            this.currentValue.Text = Calculator.Calculate().ToString();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            Calculator.Multiply();
            this.expressionPreview.Text = Calculator.GetPreview();
            this.currentValue.Text = Calculator.Calculate().ToString();
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            Calculator.Divide();
            this.expressionPreview.Text = Calculator.GetPreview();
            this.currentValue.Text = Calculator.Calculate().ToString();
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            string result = Calculator.Equals().ToString();
            string preview = Calculator.GetPreview();
            Calculator.Clear();

            this.currentValue.Text = result;
            this.expressionPreview.Text = Calculator.GetPreview();
            this.history.Text += $"{preview} = {result}\n";
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            Calculator.Sin();
            this.expressionPreview.Text = Calculator.GetPreview();
            this.currentValue.Text = Calculator.Calculate().ToString();
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            Calculator.Cos();
            this.expressionPreview.Text = Calculator.GetPreview();
            this.currentValue.Text = Calculator.Calculate().ToString();
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            Calculator.Tan();
            this.expressionPreview.Text = Calculator.GetPreview();
            this.currentValue.Text = Calculator.Calculate().ToString();
        }

        private void Log_Click(object sender, EventArgs e)
        {
            Calculator.Log();
            this.expressionPreview.Text = Calculator.GetPreview();
            this.currentValue.Text = Calculator.Calculate().ToString();
        }

        private void Mod_Click(object sender, EventArgs e)
        {
            Calculator.Mod();
            this.expressionPreview.Text = Calculator.GetPreview();
            this.currentValue.Text = Calculator.Calculate().ToString();
        }

        private void Pi_Click(object sender, EventArgs e)
        {
            Calculator.PI();
            this.expressionPreview.Text = Calculator.GetPreview();
            this.currentValue.Text = Calculator.GetExpression();
        }

        private void Root_Click(object sender, EventArgs e)
        {
            Calculator.Sqrt();
            this.expressionPreview.Text = Calculator.GetPreview();
            this.currentValue.Text = Calculator.Calculate().ToString();
        }

        private void RaiseTwo_Click(object sender, EventArgs e)
        {
            Calculator.Squared();
            this.expressionPreview.Text = Calculator.GetPreview();
            this.currentValue.Text = Calculator.Calculate().ToString();
        }

        private void RaiseY_Click(object sender, EventArgs e)
        {
            Calculator.Raise();
            this.expressionPreview.Text = Calculator.GetPreview();
            this.currentValue.Text = Calculator.Calculate().ToString();
        }

        private void Factorial_Click(object sender, EventArgs e)
        {
            Calculator.Factorial();
            this.expressionPreview.Text = Calculator.GetPreview();
            this.currentValue.Text = Calculator.Calculate().ToString();
        }

        private void Exp_Click(object sender, EventArgs e)
        {
            Calculator.Exp();
            this.expressionPreview.Text = Calculator.GetPreview();
            this.currentValue.Text = Calculator.Calculate().ToString();
        }

        private void Round_Click(object sender, EventArgs e)
        {
            Calculator.Round();
            this.expressionPreview.Text = Calculator.GetPreview();
            this.currentValue.Text = Calculator.Calculate().ToString();
        }

        private void ShowHistoryBtn_Click(object sender, EventArgs e)
        {
            if (historyPanel.Height > 0)
            {
                historyPanel.Size = new Size(historyPanel.Width, 0);
                return;
            }

            historyPanel.Size = new Size(historyPanel.Width, 244);
        }

        private void ClearHistory_Click(object sender, EventArgs e)
        {
            this.history.Text = "";
        }
    }
}