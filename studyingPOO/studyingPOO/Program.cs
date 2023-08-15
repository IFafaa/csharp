using studyingPOO;
using System;


namespace EstudandoPoo 
{
    internal class Program {
        static Pessoa usuario = new Pessoa();
        static Funcionario secretaria = new Funcionario();
        static Funcionario analista = new Funcionario();

        static void Main(string[] args) {
            //lerPessoa();
            LerFuncionarios();
        }
        static void LerPessoa() {
            Console.WriteLine("Por favor, digite seu nome:");
            usuario.Nome = Console.ReadLine();

            Console.WriteLine("Por favor, digite sua idade:");
            usuario.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, digite sua profissão");
            usuario.Profissao = Console.ReadLine();

            Console.WriteLine($"Seu nome é: {usuario.Nome}");
            Console.WriteLine($"Sua idade é: {usuario.Idade}");
            Console.WriteLine($"Sua profissão é: {usuario.Profissao}");
        }

        static void LerFuncionarios() {
            Console.WriteLine("Por favor, digite o nome da sua secretária:");
            secretaria.Nome = Console.ReadLine();
            Console.WriteLine("Por favor, digite o salário da sua secretária:");
            secretaria.Salario= int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, digite o nome do seu analista:");
            analista.Nome = Console.ReadLine();
            Console.WriteLine("Por favor, digite o salário do seu analista:");
            analista.Salario = int.Parse(Console.ReadLine());

            //Array salarios = [analista.Salario, secretaria.Salario];
            Console.WriteLine("O salário médio dos dois é de: R$" +
                (analista.Salario + secretaria.Salario) / 2
                );   
        }

        //static double calcularMedia(Array salarios) {
        //    double total = 0;
        //    for(int i = 0; i < salarios.Length; i++) {
        //        total += salarios[i];
        //    }
        //}
    }
}