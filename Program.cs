using System;

namespace Ola_usuario
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string nome;                        // define variavel nome como string
            
            Console.WriteLine("Qual seu Nome?");// imprime msg  solicitando nome usuario
            nome = Console.ReadLine();          // entrada do nome do usuario armazenada na variavel nome
            
            Console.Clear();                    // limpa a tela
            int tamanho = nome.Length;          // armazena em tamanho o total de caracteres de nome
            
            string lin = new string('*', tamanho+11);         // calcula o tamanho da janela
            Console.ForegroundColor = ConsoleColor.DarkYellow;// muda cor da caracter da janela

            Console.WriteLine(lin);                           // imprime a linha superior
            Console.Write("* ");                              // imprime parede esquerda
            Console.ForegroundColor = ConsoleColor.White;     // mudar cor para frase

            Console.Write($"Ola!!, {nome}");                  // imprime a msg Ola!! + o conteudo da varialvel nome
            Console.ForegroundColor = ConsoleColor.DarkYellow;// muda cor para parede
            Console.WriteLine(" *");                          // imprime parede direita
            Console.WriteLine(lin);                           // imprime linha inferior
            Console.ForegroundColor = ConsoleColor.White;     // retorna branco

        }
    }
}
