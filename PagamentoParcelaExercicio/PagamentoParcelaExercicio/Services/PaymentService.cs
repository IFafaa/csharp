using PagamentoParcelaExercicio.Entities;

namespace PagamentoParcelaExercicio.Services {
    internal class PaymentService {

        private ITaxService _taxService;
        public PaymentService(ITaxService taxService) {
            _taxService = taxService;
        }
        public void ProcessInstallments(Contract contract, int numberOfInstallments) {
            double valueWihoutTaxAndFees = contract.TotalValue / numberOfInstallments;
            for (int i = 0; i < numberOfInstallments; i++) {
                DateTime dueDate = contract.Date.AddMonths(i + 1);
                double amountWithoutTax = valueWihoutTaxAndFees + (valueWihoutTaxAndFees * (0.01 * (i + 1)));
                double amount = amountWithoutTax + _taxService.Tax(amountWithoutTax);
                Installment installment = new Installment(dueDate, amount);
                contract.Installment.Add(installment);
            }
        }
    }
}
