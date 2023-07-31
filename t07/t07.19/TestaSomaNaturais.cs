namespace t07._19
{
    public class TestaSomaNaturais
    {
        public static long SomaNaturais(int n)
        {
            int c = 1;
            long s = 0;

            while (c <= n)
            {
                s = s + c;
                c++;
            }
            return s;
        }

        public static void Main()
        {
            Console.WriteLine(SomaNaturais(10));
        }
    }
}