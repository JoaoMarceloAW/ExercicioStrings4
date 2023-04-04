using System.Net.Http.Headers;

namespace ExercicioStrings4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a frase que você deseja");

            string menssagemImputada = Console.ReadLine();
            string letramaisucula;
            string letraminuscula;
            int qtdLetras = 0;
            string primeiraspalavras;
            char ultimapalavra;

            letramaisucula = menssagemImputada.ToUpper();
            Console.WriteLine("A menssagem em maiusculo é: " + letramaisucula);

            letraminuscula = menssagemImputada.ToLower();


            Console.WriteLine("A sua menssagem em minusculo é:" + letraminuscula);

            for (int i = 0; i < menssagemImputada.Length; i++)
            {
                if (menssagemImputada[i] != ' ')
                {
                    qtdLetras++;



                    
                }

                

            }


            Console.WriteLine("A quantidade de letras do programa é de: " + qtdLetras);


            primeiraspalavras = menssagemImputada.Substring(0, 1);

            Console.WriteLine("A primeira Palavra da sua frase é: " + primeiraspalavras);


            ultimapalavra = menssagemImputada[menssagemImputada.Length - 1];


            Console.WriteLine("A ultima palavra da sua frase é: " + ultimapalavra);

            Console.ReadKey();











        }
    }
}