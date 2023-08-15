

namespace exerciciosOop {
    internal class Retangulo {
        public double Largura;
        public double Altura;

        public double Area() {
            return Largura * Altura;
        }

        public double Perimetro() {
            return (Largura + Altura) * 2;
        }

        public double Diagonal() {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }

        public override string ToString() {
            return $"Lagura: {Largura}, Altura: {Altura}, Área: {Area()}, Perímetro: {Perimetro()}, Diagonal: {Diagonal().ToString("N2")}";
        }
    }
}
