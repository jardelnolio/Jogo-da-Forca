using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jogo_da_Forca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jardel Mario Nolio, Matheus de Rossi Cardoso

            Loop();                            // loop utilizado para rodar o jogo mais uma vez no final
            if (Console.ReadLine() == "")
            {
                Loop();
            }

           
        }
        static void Loop()
        {
            string continuar;

            string palavra;
            int acertos = 0;
            int erros = 0;



            Console.WriteLine("Jogo da Forca - por Jardel Nolio e Matheus De Rossi Cardoso\n\n"); 
            Console.WriteLine("Digite uma palavra para ser adivinhada pelo oponente"); 
            palavra = Console.ReadLine();

            char[] letras = palavra.ToCharArray();   // char usado para definir a palavra a ser adivinhada, igualando-a com as letras seguintes que serão diitadas
            char[] forca = palavra.ToCharArray();   // definir o formato da forca e o tamanho dos espaços das letras abaixo dela
            char[] digitados = palavra.ToCharArray();


            char digitos;


            for (int i = 0; i < palavra.Length; i++)   //comando for usado para definir a relação entre o tamanho da palavra e o número de letras a serem adivinhadas abaixo da forca
            {
                if (letras[i] == ' ')
                {
                    forca[i] = ' ';
                }
                else
                {
                    forca[i] = '_';
                }
            }
            Console.Clear();

            do
            {

                Console.Write(" ________\n" +                     //desenho geral da forca
                                     "|        |\n" +
                                     "|        |\n" +
                                     "|\n" +
                                     "|\n" +
                                     "|\n" +
                                     "|\n" +
                                     "|\n" +
                                     "|\n\n");




                Console.SetCursorPosition(2, Console.CursorTop - 2);

                for (int i = 0; i < palavra.Length; i++)
                {
                    Console.Write(forca[i] + " ");
                }



                Console.WriteLine("\n\n\nDigite uma letra");
                digitos = Convert.ToChar(Console.Read());               //comando usado para digitar as letras a serem adivinhadas conforme a palavra escrita anteriormente


                for (int i = 0; i < palavra.Length; i++)
                {

                    if (digitos == forca[i])                           //comando if usado para definir se as letras digitadas são iguais as da palavra definida anteriormente
                    {
                        Console.WriteLine("\nCaractere já Digitado, para prosseguir -- Pressione Enter");
                        Console.ReadKey();
                    }


                    else if (digitos == letras[i])
                    {
                        forca[i] = digitos;
                        acertos++;
                    }

                    /* else if (digitos != forca[i])
                     {
                         Console.WriteLine("Letra não existe -- Aperte Enter");

                         Console.ReadKey();
                         erros++;

                     }*/
                }

                Console.Clear();


            } while (acertos < palavra.Length);
            Console.Clear();

            Console.WriteLine("Parabéns, você ACERTOU");
            Console.WriteLine("Caso queira jogar novamente, aperte Enter");        //repetição do jogo mais uma vez após terminá-lo
            Console.ReadKey();
            


        }
    }
}