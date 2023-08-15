namespace exerciciosOop {
    internal class Aluno { 
        public string Nome = "";
        public double PrimeiroTrimeste;
        public double SegundoTrimeste;
        public double TerceiroTrimeste;

        public double NotaTotal() {
            return (PrimeiroTrimeste + SegundoTrimeste + TerceiroTrimeste);
        }

        public bool FoiAprovado() {
            return NotaTotal() > 60;
        }

        public double PontosFaltantes() {
            return 60 - NotaTotal();
        }

        public override string ToString() { 
            return $"Nome: {Nome} 1º: {PrimeiroTrimeste}, 2º: {SegundoTrimeste}, 3º: {TerceiroTrimeste}, Total: {NotaTotal()}";
        }
    }
}
