using System;

namespace Palíndromo
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string[] Lista =
          {
            "salas",
            "socos",
            "ele",
            "mirim",
            "reviver",
            "level",
            "Livro",
            "Nada" };

            foreach (var palavra in Lista)
            {
                Console.WriteLine("A palavra :" + palavra + " é um palindrome ?  " + VerificaSeEPalindrome(palavra));

            }

            Console.ReadKey();
        }

        private static bool VerificaSeEPalindrome(string palavra)
        {
            int minimo = 0;
            int maximo = palavra.Length - 1;
            while (true)
            {

                if (minimo > maximo)
                {

                    return true;
                }

                Char auxiliar = palavra[minimo];
                Char auxiliar2 = palavra[maximo];

                if (char.ToLower(auxiliar) != char.ToLower(auxiliar2))
                {

                    return false;
                }
                minimo++;
                maximo--;
            }

        }





    }
}
