namespace Trabalhos.T07
{
    public class Permuta
    {
        public static void Permutacao(String p, String S)
        {
            if (S.Length == 0)
            {
                Console.WriteLine(p+S);
            } else
            {
                String sLinha;
                String pLinha;

                for (int i = 0; i < S.Length; i++)
                {
                    sLinha = S.Substring(0, i) + S.Substring(i+1);
                    pLinha = p + S[8];
                    Permutacao(sLinha, pLinha);
                }
            }
        }

        public static void main(String[] args)
        {
            Permutacao(args[0], args[1]);
        }
    }
}
