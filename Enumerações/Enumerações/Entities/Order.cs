using System;
using Enumeracoes.Entities.Enums;

namespace Enumeracoes.Entities
{
    internal class Order
    {
        public int IdPedido { get; private set; }
        public int IdProduto { get; private set; }
        public DateTime Moment { get; private set; }
        public OrderStatus Status { get; private set; }
        public Order(int idProduto) { 
           IdProduto = idProduto;
           Moment = DateTime.Now;
           Status = OrderStatus.PendingPayment;
        }

        public override string ToString() {
            return $"{IdPedido} - Produto {IdProduto} - Horário: {Moment} - Status: {Status}";
        }
    }
}
