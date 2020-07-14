using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
    }
}
