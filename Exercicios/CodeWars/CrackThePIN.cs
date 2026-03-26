using System.Security.Cryptography;
using System.Text;

namespace Exercicios.CodeWars
{

    /*
        É fornecido um hash MD5 de um PIN de cinco dígitos. 
        Ele é fornecido como uma string. 
        MD5 é uma função para gerar o hash da sua senha: "password123" ===> "482c811da5d5b4bc6d497ffa98491e38"
     */

    internal class CrackThePIN
    {
        public static string crack(string hash)
        {
            for (int i = 0; i <= 99999; i++)
            {
                string pin = i.ToString("D5");
                var asd = GerarMD5(pin);
                if (asd == hash)
                {
                    return pin;
                }
            }
            return "";
        }

        public static string GerarMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);

                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
