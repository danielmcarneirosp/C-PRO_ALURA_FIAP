namespace Aula03_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
              Exercício: A ONG "Solidariedade Sem Fronteiras" está empenhada em coletar e processar dados para melhorar suas ações de apoio 
              às comunidades carentes. 
              Eles precisam de um programa que permita registrar informações sobre as doações recebidas e, 
              em seguida, analisar e apresentar estatísticas sobre essas doações. Você foi convidado a elaborar este programa, 
              considere os seguintes requisitos: 
              1. Solicitar ao usuário o número de doações recebidas no mês. 
              2. Para cada doação, solicitar ao usuário o valor doado. 
              3. Calcular e armazenar o valor total das doações recebidas. 
              4. Verificar se o valor total das doações é superior a R$ 10.000,00.
                  a) * Se for superior, exibir a mensagem "Parabéns! O valor das doações é significativo para a ONG.". 
                  b) Se for igual ou inferior, exibir a mensagem "O valor das doações precisa ser aumentado para garantir 
                     a continuidade dos projetos da ONG.". 
              5. Solicitar ao usuário o número de projetos que a ONG realizou no mês. 
              6. Verificar se o número de projetos é maior ou igual a 3.
              7. Calcular e armazenar a média de valor das doações recebidas por projeto (valor total das doações dividido pelo número 
                 de projetos). 
              8. Exibir a média de valor das doações por projeto com duas casas decimais. 
              9. Exibir a quantidade de doações recebidas. 
              10. Exibir o valor total das doações recebidas. 
              11. Exibir a média de valor das doações recebidas por projeto. 
              12. Encerrar o programa exibindo uma mensagem de agradecimento e encorajamento para a continuidade do trabalho 
                  da ONG.
            */

            Console.WriteLine("Bem-vindo ao programa de doações da ONG Solidariedade Sem Fronteiras!");
            Console.Write("Digite o número de doações recebidas no mês: ");
            int numeroDoacoes = int.Parse(Console.ReadLine());
         
            double valorTotalDoacoes = 0;
            for (int i = 1; i <= numeroDoacoes; i++)
            {
                Console.Write($"Digite o valor da doação {i}º Projeto: ");
                double valorDoacao = double.Parse(Console.ReadLine());
                valorTotalDoacoes += valorDoacao;
            }
            Console.WriteLine($"Valor total das doações: R$ {valorTotalDoacoes:F2}");
            if (valorTotalDoacoes > 10000)
                Console.WriteLine("Parabéns! O valor das doações é significativo para a ONG.");
            else
                Console.WriteLine("O valor das doações precisa ser aumentado para garantir a continuidade dos projetos da ONG.");
 
            Console.Write("Digite o número de projetos realizados no mês: ");
            int numeroProjetos = int.Parse(Console.ReadLine());
            
            if (numeroProjetos >= 3)
               Console.WriteLine("A ONG realizou um bom número de projetos este mês.");
            else
               Console.WriteLine("A ONG precisa aumentar o número de projetos realizados para atender melhor as comunidades carentes.");

            double mediaDoacoesPorProjeto = valorTotalDoacoes / numeroProjetos;
            
            Console.WriteLine($"Média de valor das doações por projeto: R$ {mediaDoacoesPorProjeto:F2}");
            Console.WriteLine($"Quantidade de doações recebidas: {numeroDoacoes}");
            Console.WriteLine($"Valor total das doações recebidas: R$ {valorTotalDoacoes:F2}");
            Console.WriteLine($"Média de valor das doações recebidas por projeto: R$ {mediaDoacoesPorProjeto:F2}");
            Console.WriteLine("Agradecemos sua contribuição e encorajamos a continuidade do trabalho da ONG!");
            Console.WriteLine("Até a próxima!");


        }
    }
}
