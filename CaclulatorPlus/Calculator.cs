using System;
using System.Collections.Generic;

namespace CalculatorPlus
{
    class Calculator
    {
        private static string expression = "0";
        private static string infix = "";
        private static string preview = "";
        private static bool isRecentlyCalc = false;

        public static void Add()
        {
            infix += $"{expression} + ";
            preview += $"{expression} + ";
        }

        public static void Subtract()
        {
            infix += $"{expression} - ";
            preview += $"{expression} - ";
        }

        public static void Multiply()
        {
            infix += $"{expression} * ";
            preview += $"{expression} × ";
        }

        public static void Divide()
        {
            infix += $"{expression} / ";
            preview += $"{expression} ÷ ";
        }

        public static void InsertDecimalPoint()
        {
            if (!expression.Contains('.'))
            {
                expression += ".";
            }
        }

        public static double Equals() {
            infix += expression;
            double result = Calculate();

            Clear();
            return result;
        }

        public static void SetExpression(double val)
        {
            double currentValue = Convert.ToDouble(expression);

            if ((currentValue != 0 || expression.Contains('.')) && !isRecentlyCalc)
            {
                expression += val;
            }
            else
            {
                expression = val.ToString();
                isRecentlyCalc = false;
            }
        }

        public static void Remove()
        {
            if (expression.Length > 1)
            {
                expression = expression.Remove(expression.Length - 1, 1);
            }
            else
            {
                Reset();
            }
        }

        public static void Clear()
        {
            preview = "";
            infix = "";
        }

        public static void Reset()
        {
            expression = "0";
            infix = "";
            preview = "";
        }

        public static string GetExpression()
        {
            return expression;
        }

        public static string GetPreview()
        {
            return preview;
        }

        private static string ParseInfix(string infix)
        {
            int i = infix.Length - 1;

            // Trim ends of infix
            while (i >= 0 && !char.IsDigit(infix[i]))
            {
                if (char.IsWhiteSpace(infix[i]) || IsOperator(infix[i].ToString()))
                {
                    i--;
                }
                else
                {
                    break;
                }
            }

            // Split into an array
            return infix[..(i + 1)];
        }

        private static string ToPostFix(string infix)
        {
            string postfix = "";
            string[] infixArr = ParseInfix(infix).Split(' ');
            Stack<char> stack = new();

            foreach (string token in infixArr)
            {
                if (IsOperand(token))
                {
                    postfix += $"{token} ";
                }

                if (IsOperator(token))
                {
                    char c = Convert.ToChar(token);

                    if (stack.Count > 0 && GetOperatorPrecedence(c) <= GetOperatorPrecedence(stack.Peek()))
                    {
                        postfix += $"{stack.Pop()} ";
                    }

                    stack.Push(c);
                }
            }

            while (stack.Count > 0)
            {
                postfix += $"{stack.Pop()} ";
            }

            return postfix;
        }

        public static double Calculate()
        {
            Console.WriteLine(preview);
            isRecentlyCalc = true;

            string[] postfix = ToPostFix(infix).Split(" ");
            Stack<string> stack = new();

            foreach (string token in postfix)
            {
                if (IsOperand(token))
                {
                    stack.Push(token);
                }

                if (IsOperator(token))
                {
                    double a = Convert.ToDouble(stack.Pop());
                    double b = Convert.ToDouble(stack.Pop());

                    switch(token)
                    {
                        case "+":
                            stack.Push(Convert.ToString(b + a));
                            break;
                        case "-":
                            stack.Push(Convert.ToString(b - a));
                            break;
                        case "*":
                            stack.Push(Convert.ToString(b * a));
                            break;
                        case "/":
                            stack.Push(Convert.ToString(b / a));
                            break;

                    }
                }
            }

            expression = stack.Pop();

            return Convert.ToDouble(expression);
        }

        private static bool IsOperator(string op)
        {
            return char.TryParse(op, out char c) && (c == '+' || c == '-' || c == '*' || c == '/');
        }

        private static bool IsOperand(string operand)
        {
            return double.TryParse(operand, out _);
        }

        private static int GetOperatorPrecedence(char op)
        {
            return op switch
            {
                '+' or '-' => 1,
                '*' or '/' => 2,
                '^' => 3,
                _ => 0,
            };
        }
    }
}
