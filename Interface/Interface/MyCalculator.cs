namespace Interface
{
    public class MyCalculator : IAdvancedArithmetic
    {
        public int divisor_sum(int n)
        {
            var sum = 0;

            for (var i = 1; i <= n; i++)
                if (IsDivisor(n, i))
                    sum += i;

            return sum;
        }

        private static bool IsDivisor(int number, int divisor)
        {
            return number % divisor == 0;
        }
    }
}