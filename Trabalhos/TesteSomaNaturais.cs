namespace Trabalhos
{
    public class TesteSomaNaturais
    {
        public static long SomaNaturais (int n)
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

        public static void main()
        {
            Console.WriteLine(SomaNaturais(10));
        }
    }
}
