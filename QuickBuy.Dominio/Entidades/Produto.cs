using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validady()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Informe o nome do produto.");
            }
            if (string.IsNullOrEmpty(Descricao))
            {
                AdicionarCritica("Informe uma breve descrição referente ao produto.");
            }
            if (Preco <= 0)
            {
                AdicionarCritica("Informe um preço válido do produto.");
            }
        }
    }
}
