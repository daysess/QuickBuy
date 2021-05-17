using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        // Usuarios pode ter nenhum ou muitos pedidos
        public ICollection<Pedido>  Pedidos { get; set; }

        public override void Validady()
        {
            if (string.IsNullOrEmpty(Email))
            {
                AdicionarCritica("Informe o email do usuário.");
            }
            if (string.IsNullOrEmpty(Senha))
            {
                AdicionarCritica("Informe uma senha válida.");
            }
            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Informe o nome do usuário.");
            }
            if (string.IsNullOrEmpty(SobreNome))
            {
                AdicionarCritica("Informe o sobre nome do usuário.");
            }
        }
    }
}
