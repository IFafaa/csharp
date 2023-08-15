
namespace Estoque {
    internal class Produto {
        //QUANDO USAR ATRIBUTOS PRIVADOS USAR _abc
        public string Nome{ get; set; }
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }


        public Produto() { }
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Preco = quantidade;
        }

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
            Quantidade = 0;
        }

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantity) {
            Quantidade += quantity;
        }
        public void RemoverProdutos(int quantity) {
            Quantidade -= quantity;
        }
 
        public override string ToString() {
            return $"Dados do produto: {Nome}, ${Preco}, {Quantidade} unidades, Total: ${ValorTotalEmEstoque()}";
        }
    }
}
