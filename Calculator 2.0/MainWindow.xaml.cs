using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator_2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double first = default(double);
        double second = default(double);
        double result = default(double);
        double current = default(double);
        bool turn = false;
        public MainWindow()
        {
            InitializeComponent();
            ResultScreen.Text = "0";
        }

        private void BackSpace_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(ResultScreen.Text))
            {
                int len = ResultScreen.Text.Length;
                string[] temp = new string[len - 1];

                for (int i = 0; i < len - 1; i++)
                {
                    temp[i] = ResultScreen.Text[i].ToString();
                }
                ResultScreen.Text = string.Empty;
                for (int i = 0; i < len - 1; i++)
                {
                    ResultScreen.Text += temp[i];
                }
            }
            else
            {
                ResultScreen.Text = "0";
            }

        }

        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            // ResultScreen.Text = "0";
        }

        private void SQR_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SQRT_Click(object sender, RoutedEventArgs e)
        {

        }

        string operation_1 = default(string);
        string operation_2 = default(string);
        int lastIndex = default(int);
        char[] opts = Operation.GetCharArray();

        private void Operations_Button_Click(object sender, RoutedEventArgs e)
        {
            var opr = sender as Button;

            if (!turn)
            {
                operation_1 = Operation.GetOperation(opr.Name);

                for (int i = 0; i < ResultScreen.Text.Length; i++)
                {
                    if (i > 0)
                    {
                        first *= 10;
                    }
                    first += Convert.ToDouble(ResultScreen.Text[i].ToString());
                }
                turn = true;
                //lastIndex = ResultScreen.Text.Length + 1;
            }
            else
            {
                //double res = default(double);

                // if (!double.TryParse(ResultScreen.Text[lastIndex].ToString(), out res))
                // {
                //     lastIndex += 1;
                // }

                //if (ResultScreen.Text.Length - 1 < lastIndex)
                //{
                //    lastIndex--;
                //}

                for (int i = 0; i < ResultScreen.Text.Length; i++)
                {
                    if (ResultScreen.Text[i] == opts[0] || ResultScreen.Text[i] == opts[1] || ResultScreen.Text[i] == opts[2] || ResultScreen.Text[i] == opts[3])
                    {
                        lastIndex = i + 1;
                    }
                }

                for (int i = lastIndex; i < ResultScreen.Text.Length; i++)
                {
                    second = (second * 10) + Convert.ToDouble(ResultScreen.Text[i].ToString());
                }

                operation_2 = Operation.GetOperation(opr.Name);

                CalculateResult();
            }

            ResultScreen.Text += operation_1;

        }

        private void CalculateResult()
        {
            if (second == 0)
            {
                second = 1;
            }
            if (operation_1 == "+")
            {
                result = first + second;
            }
            else if (operation_1 == "-")
            {
                result = first - second;
            }
            else if (operation_1 == "/")
            {
                result = first / second;
            }
            else
            {
                result = first * second;
            }

            second = default(double);
            first = result;
            operation_1 = operation_2;
            operation_2 = string.Empty;

            ResultScreen.Text = result.ToString();
            result = default(double);
        }
        //private bool IsOperation(string str)
        //{
        //    if (str == Operation.Divide || str == Operation.Multiply || str == Operation.Minus || str == Operation.Plus)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        private void Numpad_Button_Click(object sender, RoutedEventArgs e)
        {
            var number = sender as Button;

            if (ResultScreen.Text == "0")
            {
                ResultScreen.Text = string.Empty;
            }

            switch (number.Name)
            {
                case Number.One:
                    {
                        ResultScreen.Text += "1";
                        break;
                    }
                case Number.Two:
                    {
                        ResultScreen.Text += "2";
                        break;
                    }
                case Number.Three:
                    {
                        ResultScreen.Text += "3";

                        break;
                    }
                case Number.Four:
                    {
                        ResultScreen.Text += "4";

                        break;
                    }
                case Number.Five:
                    {
                        ResultScreen.Text += "5";
                        break;
                    }
                case Number.Six:
                    {
                        ResultScreen.Text += "6";

                        break;
                    }
                case Number.Seven:
                    {
                        ResultScreen.Text += "7";

                        break;
                    }
                case Number.Eight:
                    {

                        ResultScreen.Text += "8";

                        break;
                    }
                case Number.Nine:
                    {
                        ResultScreen.Text += "9";

                        break;
                    }
                case Number.Zero:
                    {
                        ResultScreen.Text += "0";//fix that ;)
                        break;
                    }
            }
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < ResultScreen.Text.Length; i++)
            {
                if (ResultScreen.Text[i] == opts[0] || ResultScreen.Text[i] == opts[1] || ResultScreen.Text[i] == opts[2] || ResultScreen.Text[i] == opts[3])
                {
                    lastIndex = i + 1;
                }
            }

            for (int i = lastIndex; i < ResultScreen.Text.Length; i++)
            {
                second = (second * 10) + Convert.ToDouble(ResultScreen.Text[i].ToString());
            }
            CalculateResult();
            ResultScreen.Text += operation_1;
        }

        private void signChangeBtn_Click(object sender, RoutedEventArgs e)
        {

            double temp = second;
            for (int i = 0; i < ResultScreen.Text.Length; i++)
            {
                if (ResultScreen.Text[i] == opts[0] || ResultScreen.Text[i] == opts[1] || ResultScreen.Text[i] == opts[2] || ResultScreen.Text[i] == opts[3])
                {
                    lastIndex = i + 1;
                }
            }

            for (int i = lastIndex; i < ResultScreen.Text.Length; i++)
            {
                temp = (temp * 10) + Convert.ToDouble(ResultScreen.Text[i].ToString());
            }

            temp *= -1;



             //MessageBox.Show(second.ToString());
            //char[] temp = new char[1];

            //temp = ResultScreen.Text.ToCharArray();

            //if (ResultScreen.Text.Contains(Operation.Divide) || ResultScreen.Text.Contains(Operation.Multiply) || ResultScreen.Text.Contains(Operation.Minus) || ResultScreen.Text.Contains(Operation.Plus))
            //{
            //    double res = 0;

            //    for (int i = 0; i < ResultScreen.Text.Length; i++)
            //    {
            //        if (!double.TryParse(ResultScreen.Text[i].ToString(), out res))
            //        {
            //            res = 0;
            //            for (int j = i + 1; j < ResultScreen.Text.Length; j++)
            //            {
            //                if (j > 0)
            //                {
            //                    res *= 10;
            //                }
            //                res += temp[j];
            //            }
            //            res *= -1;
            //            break;
            //        }
            //    }
            //    ResultScreen.Text += "(" + res + ")";
            //}
            //else
            //{
            //    for (int i = 0; i < ResultScreen.Text.Length; i++)
            //    {
            //        if (i > 0)
            //        {
            //            first *= 10;
            //        }
            //        first += Convert.ToDouble(ResultScreen.Text[i].ToString());
            //    }
            //    first *= -1;
            //    ResultScreen.Text = first.ToString();
            //}
        }

        private void divide2onebtn_Click_1(object sender, RoutedEventArgs e)
        {
            //divide2onebtn
            string temp = string.Empty;
            double n1 = 0;
            double n2 = 0;

            if (!turn)
            {
                for (int i = 0; i < ResultScreen.Text.Length; i++)
                {
                    if (i > 0)
                    {
                        n1 *= 10;
                    }
                    n1 += Convert.ToDouble(ResultScreen.Text[i].ToString());
                }

                n1 = 1 / n1;
                temp = n1.ToString();
                ResultScreen.Text = temp;
            }
            else
            {

                for (int i = lastIndex; i < ResultScreen.Text.Length; i++)
                {
                    n2 = (n2 * 10) + Convert.ToDouble(ResultScreen.Text[i].ToString());
                }

                n2 = 1 / n2;
                //n2
                temp = first.ToString();
                ResultScreen.Text = temp;
            }

        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{

        //}

        private void seperator_Click(object sender, RoutedEventArgs e)
        {

        }


    }
    static class Number
    {
        public const string One = "one";
        public const string Two = "two";
        public const string Three = "three";
        public const string Four = "four";
        public const string Five = "five";
        public const string Six = "six";
        public const string Seven = "seven";
        public const string Eight = "eight";
        public const string Nine = "nine";
        public const string Zero = "zero";
    }
    static class Operation
    {
        public const string Plus = "+";
        public const string Minus = "-";
        public const string Multiply = "x";
        public const string Divide = "/";


        static public char[] GetCharArray()
        {
            char[] arr = new char[4];
            arr[0] = '+';
            arr[1] = '-';
            arr[2] = 'x';
            arr[3] = '/';

            return arr;
        }

        static public string GetOperation(string operation)
        {
            if (operation == "Plus")
            {
                return Operation.Plus;
            }
            else if (operation == "Minus")
            {
                return Operation.Minus;
            }
            else if (operation == "Multiply")
            {
                return Operation.Multiply;
            }
            else
            {
                return Operation.Divide;
            }

        }

    }
}
