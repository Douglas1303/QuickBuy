﻿using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entities
{
    public class Pedido : Entity
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
        public virtual FormaPagamento FormaPagamento { get; set; }

        //Pedido deve ter pelo menos um item de pedido 
        //ou muitos itens de pedidos 
        public virtual ICollection<ItemPedido> ItemPedido { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao(); 

            if (!ItemPedido.Any())
                AdicionarCritica("Erro - Pedido deve conter pelo menos 1 item!");

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Erro - Cep deve estar preenchido!");

            if (FormaPagamentoId == 0)
                AdicionarCritica("Erro - Não foi informado a forma de pagamento!"); 
                
        }
    }
}
