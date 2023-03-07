using CaclulatorPlus;
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
        private static bool isRecentlyFunc = false;

        public static void Sin()
        {
            isRecentlyFunc = true;
            infix += $"{Math.Sin(double.Parse(expression))} ";
            preview += $"sin({expression}) ";
        }

        // cos
        public static void Cos()
        {
            isRecentlyFunc = true;
            infix += $"{Math.Cos(double.Parse(expression))} ";
            preview += $"cos({expression}) ";
        }

        // tan
        public static void Tan()
        {
            isRecentlyFunc = true;
            infix += $"{Math.Tan(double.Parse(expression))} ";
            preview += $"tan({expression}) ";
        }

        // log
        public static void Log()
        {
            isRecentlyFunc = true;
            infix += $"{Math.Log(double.Parse(expression))} ";
            preview += $"log({expression}) ";
        }

        // pi
        public static void PI()
        {
            infix += $"{Math.PI} ";
            expression = Math.PI.ToString();
        }

        // square root
        public static void Sqrt()
        {
            isRecentlyFunc = true;
            infix += $"{Math.Sqrt(double.Parse(expression))} ";
            preview += $"sqrt({expression}) ";
        }

        // x2
        public static void Squared()
        {
            isRecentlyFunc = true;
            infix += $"{Math.Pow(double.Parse(expression), 2)} ";
            preview += $"{expression} ^ 2 ";
        }

        // exp
        public static void Exp()
        {
            isRecentlyFunc = true;
            infix += $"{Math.Exp(double.Parse(expression))} ";
            preview += $"exp({expression}) ";
        }

        public static void Round()
        {
            isRecentlyFunc = true;
            infix += $"{Math.Round(double.Parse(expression))} ";
            preview += $"round({expression}) ";
        }

        // xy
        public static void Raise()
        {
            if (isRecentlyFunc)
            {
                infix += "^ ";
                preview += "^ ";

                isRecentlyFunc = false;
                return;
            }

            infix += $"{expression} ^ ";
            preview += $"{expression} ^ ";
        }

        // factorial
        public static void Factorial()
        {
            isRecentlyFunc = true;

            double result = 1;
            for (double i = 1; i <= double.Parse(expression); i++)
            {
                result *= i;
            }

            infix += $"{result} ";
            preview += $"{expression}! ";
        }

        public static void Mod()
        {
            if (isRecentlyFunc)
            {
                infix += "% ";
                preview += "Mod ";

                isRecentlyFunc = false;
                return;
            }

            infix += $"{expression} % ";
            preview += $"{expression} Mod ";
        }

        public static void Add()
        {
            if (isRecentlyFunc)
            {
                infix += "+ ";
                preview += "+ ";

                isRecentlyFunc = false;
                return;
            }

            infix += $"{expression} + ";
            preview += $"{expression} + ";
        }

        public static void Subtract()
        {
            if (isRecentlyFunc)
            {
                infix += "- ";
                preview += "- ";

                isRecentlyFunc = false;
                return;
            }

            infix += $"{expression} - ";
            preview += $"{expression} - ";
        }

        public static void Multiply()
        {
            if (isRecentlyFunc)
            {
                infix += "* ";
                preview += "× ";

                isRecentlyFunc = false;
                return;
            }

            infix += $"{expression} * ";
            preview += $"{expression} × ";
        }

        public static void Divide()
        {
            if (isRecentlyFunc)
            {
                infix += "/ ";
                preview += "÷ ";

                isRecentlyFunc = false;
                return;
            }

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
            preview += expression;
            double result = Calculate();

            return result;
        }

        public static void SetExpression(double val)
        {
            double currentValue = double.Parse(expression);

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
            Console.WriteLine(infix);
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
                    double a = double.Parse(stack.Pop());
                    double b = double.Parse(stack.Pop());

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
                        case "%":
                            stack.Push(Convert.ToString(b % a));
                            break;
                        case "^":
                            stack.Push(Convert.ToString(Math.Pow(b, a)));
                            break;

                    }
                }
            }

            expression = stack.Pop();

            return double.Parse(expression);
        }

        private static bool IsOperator(string op)
        {
            return char.TryParse(op, out char c) && (c == '+' || c == '-' || c == '*' || c == '/' || c == '%' || c == '^');
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
                '*' or '/' or '%' => 2,
                '^' => 3,
                _ => 0,
            };
        }
    }
}
