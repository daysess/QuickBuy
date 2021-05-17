namespace QuickBuy.Dominio.Entidades
{
    class ItemPedido : Entidade

    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validady()
        {
            if(ProdutoId == 0)
            {
                AdicionarCritica("É necessário adicionar pelomentos um produto ao item de pedido.");
            }
            if(Quantidade == 0)
            {
                AdicionarCritica("Quantidade não informada.");
            }
        }
    }
}
