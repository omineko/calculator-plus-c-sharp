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
            this.currentValue.Text = Calculator.GetExpression();
            this.expressionPreview.Text = Calculator.GetPreview();
        }

        private void Substract_Click(object sender, EventArgs e)
        {
            Calculator.Subtract();
            this.currentValue.Text = Calculator.GetExpression();
            this.expressionPreview.Text = Calculator.GetPreview();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            Calculator.Multiply();
            this.currentValue.Text = Calculator.GetExpression();
            this.expressionPreview.Text = Calculator.GetPreview();
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            Calculator.Divide();
            this.currentValue.Text = Calculator.GetExpression();
            this.expressionPreview.Text = Calculator.GetPreview();
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            this.currentValue.Text = Calculator.Calculate().ToString();
            this.expressionPreview.Text = Calculator.GetPreview();
        }
    }
}