using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace QuickBuy.Dominio.Entities
{
    public class Usuario : Entity
    {  
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Email não informado!");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Senha não informada!"); 
        }
    }
}
