using exerciciosOop;
using System;

namespace OopExercises 
{
    internal class Program {
        static Retangulo MeuRetangulo = new Retangulo();
        static Funcionario MeuFuncionario = new Funcionario();
        static Aluno MeuAluno = new Aluno();
        
        static void Main(string[] args) {
            //LerRetangulo();
            //LerFuncionario();
            ///LerNotasAluno();
        }


        static void LerNotasAluno() {
            Console.WriteLine("Digite por favor os dados referente ao aluno:");
            Console.Write("Nome:");
            MeuAluno.Nome = Console.ReadLine();

            Console.Write("1º Trimestre:");
            MeuAluno.PrimeiroTrimeste = double.Parse(Console.ReadLine());

            Console.Write("2º Trimestre:");
            MeuAluno.SegundoTrimeste = double.Parse(Console.ReadLine());

            Console.Write("3º Trimestre:");
            MeuAluno.TerceiroTrimeste = double.Parse(Console.ReadLine());

            Console.WriteLine($"Dados: {MeuAluno.ToString()}");
            if (MeuAluno.FoiAprovado()) {
                Console.WriteLine($"O aluno foi aprovado");
            }
            else {
                Console.WriteLine($"O aluno foi reprovado, faltaram {MeuAluno.PontosFaltantes()} pontos.");
            }

        }
        static void LerFuncionario() {
            Console.WriteLine("Digite por favor os dados referente ao funcionario:");
            Console.Write("Nome:");
            MeuFuncionario.Nome = Console.ReadLine();

            Console.Write("Salário bruto:");
            MeuFuncionario.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto:");
            MeuFuncionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionário: {MeuFuncionario.ToString()}");

            Console.Write("Digite a porcentagem para aumentar o salário:");
            double porcentagem = double.Parse(Console.ReadLine());
            MeuFuncionario.AumentarSalario(porcentagem);

            Console.WriteLine($"Dados atualizados: {MeuFuncionario.ToString()}");
        }
        static void LerRetangulo() {
            Console.WriteLine("Digite por favor os dados referente ao retângulo:");

            Console.Write("Altura:");
            MeuRetangulo.Altura = double.Parse(Console.ReadLine());

            Console.Write("Largura:");
            MeuRetangulo.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine($"Os dados referentes ao retângulo são:");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine(MeuRetangulo.ToString());
        }
    }
}