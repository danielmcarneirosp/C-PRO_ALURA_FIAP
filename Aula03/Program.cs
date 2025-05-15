namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, media;
            int somaIdade = 0;
            int qtdAlunos = 1;
            /*
            Console.WriteLine("Digite a quantidade de Alunos: ");
            int contador = Convert.ToInt32(Console.ReadLine());

            //Laçõs condicionais => while
            while (qtdAlunos <= contador)
            {
                Console.WriteLine($"Digite a idade do {qtdAlunos}º aluno: ");
                idade = Convert.ToInt32(Console.ReadLine());
                somaIdade += idade;
                qtdAlunos++;
            }

            media = somaIdade / contador;
            Console.WriteLine("A média de idade dos alunos da escola é: " + media);
            */

            /*
            //Laços Do..While
            Console.WriteLine("Digite a quantidade de Alunos: ");
            int contador = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine($"Digite a idade do {qtdAlunos}º aluno: ");
                idade = Convert.ToInt32(Console.ReadLine());
                somaIdade += idade;
                qtdAlunos++;
            } while (qtdAlunos <= contador);
            media = somaIdade / contador;
            Console.WriteLine("A média de idade dos alunos da escola é: " + media);

            
            //Exercício Caixa Eletrônico
            int opcao =0;
            double saldo = 0;
            double valorSaque = 0;
            
            Console.WriteLine("Bem-vindo ao Caixa Eletrônico!");

            while (opcao !=4)
            {
                Console.Clear();
                Console.WriteLine("BANCO DMCSYSTEM");
                Console.WriteLine("1-Depósito");
                Console.WriteLine("2-Saque");
                Console.WriteLine("3-Consultar Saldo");
                Console.WriteLine("4-Sair");
                Console.WriteLine("Escolha uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o valor do depósito: ");
                        double valorDeposito = Convert.ToDouble(Console.ReadLine());
                        saldo += valorDeposito;
                        Console.WriteLine($"Depósito de {valorDeposito} realizado com sucesso!");
                        break;
                    case 2:
                        Console.WriteLine("Digite o valor do saque: ");
                        valorSaque = Convert.ToDouble(Console.ReadLine());
                        if (valorSaque > saldo)
                        {
                            Console.WriteLine("Saldo insuficiente!");
                        }
                        else
                        {
                            saldo -= valorSaque;
                            Console.WriteLine($"Saque de {valorSaque} realizado com sucesso!");
                        }
                        break;
                    case 3:
                        Console.WriteLine($"Seu saldo atual é: {saldo}");
                        Thread.Sleep(2000);
                        break;
                    case 4:
                        Console.WriteLine("Saindo...");
                        break;


                }
            }
            
            //Laços For - Contagem
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"O número {i} é par");
            }
            

            //Dado um número, exbir o fatorial dele
            Console.WriteLine("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int fatorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i;
            }
            Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
            */
            
            //Exercício 


        }
    }
}
