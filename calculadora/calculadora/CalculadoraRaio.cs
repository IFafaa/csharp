namespace calculadora {
    internal class CalculadoraRaio {
        public double raio;
        public double Pi = 3.14;

        public double Circuferencia() {
            return 2.0 * raio * Pi;
        }

        public double Volume() {
            return 4.0 / 3.0 * Pi * raio * raio * raio;
        }
    }
}
