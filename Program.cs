using System;

namespace lista4
{
    class projeto
    {
        static void Main(string[] args)
        {
            /*int numero = 0;
            while (numero <= 10) {
            Console.WriteLine(numero);
            numero++;
            }*/

            /* char resposta = char.Parse(Console.ReadLine());
             while (resposta == 's')
             {
             Console.WriteLine("Desejar continuar? ");
             resposta = char.Parse(Console.ReadLine());
             }*/

            /*for (int i = 0; i<= 10; i++)
            {
                Console.WriteLine(i);
            }*/

            /*int num = 5;
            for(int i = 0; i <= 10; i++)
            {
                int resultado = num * i;
                Console.WriteLine(resultado);
                Console.WriteLine("");
                Console.WriteLine(num + " x " + i + " = " + resultado);*/



            /*COMEÇA AQUI*/

            /*ATIVIDADE 01*/
            /*1 – Peça para o usuário informar um número e mostre a tabuada desse
            valor*/

            /*{
                Console.WriteLine("ATIVIDADE 01");
                Console.WriteLine("Informe um número para ver sua tabuada:");
                int numero = int.Parse(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(numero * i);
                }
            }*/

            /*ATIVIDADE 02*/
            /*2 – Peça para o usuário digitar um número e mostre os números do 0
            até ele pulando de três em três.*/

            /*{
                Console.WriteLine("ATIVIDADE 02");
                Console.WriteLine("Digite um número:");
                int numero = int.Parse(Console.ReadLine());

                for (int i = 0; i <= numero; i += 3)
                {
                    Console.WriteLine(i);
                }
            }*/

            /*ATIVIDADE 03*/
            /*3 – Escreva um programa que lê o número digitado pelo usuário cinco
            vezes e mostre
            - Se o número for maior que 100, escreva “NÚMERO ESPECIAL”
            - Senão, escreva “NÚMERO COMUM”*/

            /*{
                Console.WriteLine("ATIVIDADE 03");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Digite um número:");
                    int numero = int.Parse(Console.ReadLine());

                    if (numero > 100)
                    {
                        Console.WriteLine("NÚMERO ESPECIAL");
                    }
                    else
                    {
                        Console.WriteLine("NÚMERO COMUM");
                    }
                }
            }*/

            /*ATIVIDADE 04*/
            /*4 – Pergunte para o usuário se ele deseja continuar, a resposta dele
            deve ser “s” ou “n”. Enquanto a resposta for igual a “s” continue
            repetindo a pergunta*/

            /*{
                Console.WriteLine("ATIVIDADE 04");
                string resposta;
                do
                {
                    Console.WriteLine("Deseja continuar? (s/n)");
                    resposta = Console.ReadLine().ToLower();
                } while (resposta == "s");
            }*/
        }
    }
}