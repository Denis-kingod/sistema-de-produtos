using System;

namespace Exercicio_Sistema_de_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha;
            string senhaCorreta;
            int tamanhoArrays = 5;
            string[] nomes = new string[tamanhoArrays];
            string[] origens = new string[tamanhoArrays];
            string[] destinos = new string[tamanhoArrays];
            string[] datas = new string[tamanhoArrays];
            int i = 0;
            string resposta;
            bool condicao = false;

            do
            {
                Console.WriteLine("digite a senha para ter acesso ao sistema");
                senha = Console.ReadLine();

                senhaCorreta = "123456";

                if (senha == senhaCorreta)
                {
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine(@"
|====================================|                   
|    selecione uma opçoes abaixo:    |
|------------------------------------|
|    1 - Cadastrar pasagens          |             
|    2 - Listar passagem             |        
|    0 - sair                        |
|====================================|                   
                    ");
                        Console.ForegroundColor = ConsoleColor.White;

                        string opcao = Console.ReadLine();

                        switch (opcao)
                        {
                            case "1":

                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("digite o nome do passageiro");
                                    nomes[i] = Console.ReadLine();

                                    Console.WriteLine("digite a origem do passageiro");
                                    origens[i] = Console.ReadLine();

                                    Console.WriteLine("digite o destino do passageiro");
                                    destinos[i] = Console.ReadLine();

                                    Console.WriteLine("digite a data da viagem ex: xx/xx/xxxx");
                                    datas[i] = Console.ReadLine();

                                    Console.WriteLine("coce deseja cadastrar mais um passageiro? (s/n)");
                                    resposta = Console.ReadLine();

                                    i++;
                                } while (resposta == "s");

                                break;

                            case "2":
                            Console.Clear();
                                Console.WriteLine("nome        destino     origem      data");

                                for (var c = 0; c < i; c++)
                                {
                                Console.WriteLine($"{nomes[c]}      {destinos[c]}       {origens[c]}        {datas[c]}");
                                }

                                break;

                            case "0":
                            Console.Clear();
                            Console.WriteLine("obrigado por utilizar nosso sistema\n");
                            condicao = true;
                                break;

                            default:

                                break;
                        }
                    } while (!condicao);
                }
                else
                {
                    Console.WriteLine("senha incorreta! tente novamente\n");
                }

            } while (senha != senhaCorreta);


        }
    }
}
