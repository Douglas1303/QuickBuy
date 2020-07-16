using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    public class ItemPedido : Entity
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
                AdicionarCritica("Não identificado qual a referência do produto");
            if (Quantidade == 0)
                AdicionarCritica("Quantidade não foi informada"); 
            
        }
    }
}
