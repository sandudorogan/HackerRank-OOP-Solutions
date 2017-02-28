using System;

namespace Calculator
{
    public class Calculator
    {
        private static Calculator reference;

        public static Calculator do_calc()
        {
            return reference ?? (reference = new Calculator());
        }

        public int get_int_val()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public double get_double_val()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        private void CheckDimension(int i)
        {
            if (i < 0)
                throw new NotSupportedException("All the values must be positive");
        }

        private void CheckDimension(double i)
        {
            if (i < 0)
                throw new NotSupportedException("All the values must be positive");
        }

        public int get_volume(int a)
        {
            CheckDimension(a);

            return a * a;
        }

        internal double get_volume(int l, int b, int h)
        {
            CheckDimension(l);
            CheckDimension(b);
            CheckDimension(h);

            return l * b * h;
        }

        internal double get_volume(double r)
        {
            CheckDimension(r);

            return Math.Round(2d / 3d * Math.PI * Math.Pow(r, 3), 3);
        }

        internal double get_volume(double r, double h)
        {
            CheckDimension(r);
            CheckDimension(h);

            return Math.Round(Math.PI * Math.Pow(r, 2) * h, 3);
        }

        public static class output
        {
            public static void display(double volume)
            {
                Console.WriteLine(volume);
            }
        }
    }

    internal class Program
    {
        private static void Main()
        {
            try
            {
                var cal = new Calculator();
                var T = cal.get_int_val();
                while (T-- > 0)
                {
                    var volume = 0.0;
                    var ch = cal.get_int_val();

                    if (ch == 1)
                    {
                        var a = cal.get_int_val();
                        volume = Calculator.do_calc().get_volume(a);
                    }
                    else if (ch == 2)
                    {
                        var l = cal.get_int_val();
                        var b = cal.get_int_val();
                        var h = cal.get_int_val();
                        volume = Calculator.do_calc().get_volume(l, b, h);
                    }
                    else if (ch == 3)
                    {
                        var r = cal.get_double_val();
                        volume = Calculator.do_calc().get_volume(r);
                    }
                    else if (ch == 4)
                    {
                        var r = cal.get_double_val();
                        var h = cal.get_double_val();
                        volume = Calculator.do_calc().get_volume(r, h);
                    }

                    Calculator.output.display(volume);
                }
            }
            catch (NotSupportedException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            Console.ReadLine();
        }
    }
}