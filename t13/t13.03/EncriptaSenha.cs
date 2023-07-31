using System.Security.Cryptography;
using System.Text;

namespace t13._03
{
    public class EncriptaSenha
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha: ");
            string password = Console.ReadLine();

            string encryptedPassword = EncryptPassword(password);

            Console.WriteLine("Senha criptografada: " + encryptedPassword);
            Console.ReadLine();
        }

        static string EncryptPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                StringBuilder stringBuilder = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    stringBuilder.Append(hashBytes[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }
    }
}