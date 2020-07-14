using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    public class Produto : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
