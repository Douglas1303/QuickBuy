using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    public class ItemPedido : Entity
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
           
        }
    }
}
