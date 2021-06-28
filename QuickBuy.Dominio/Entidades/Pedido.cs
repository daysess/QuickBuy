using QuickBuy.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagmaento { get; set; }

        // Um pedido deve ter um item de pedido ou muitos itens de pedido.
        public virtual ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(CEP))
            {
                AdicionarCritica("Informe o CEP residencial.");
            }
            if (!ItensPedido.Any())
            {
                AdicionarCritica("Atenção: Pedido não pode ficar sem item de pedido.");
            }
        }
    }
}
