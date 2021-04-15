using System;

namespace DoadorSangue_DecisaoSimples
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade;



            Console.WriteLine("-- Formulário para doação de sangue --\n");



            Console.Write("Qual a idade do doador(a)? ");

            bool numeroValido = Int32.TryParse(Console.ReadLine(), out idade);


            if (!numeroValido)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Insira um numero válido");
                 Console.ResetColor();
                Environment.Exit(-1);
            }
            else if (idade < 18)
            {
                Console.WriteLine("Doadores menores de idade somente com autorização dos pais.");

            }
            else if (idade >= 69)
            {
                Console.WriteLine("Doadores com idade igual ou superior a 69 anos estão impossibilitados de doar.");

            }
            else
            {
                Console.WriteLine("Voce pode doar sangue, procure um hemocentro mais proximo de você!");
            }


           

        }


    }
}



