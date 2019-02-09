﻿using CasaDoCodigo.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models
{
    public class UpdateQuantidadeOutput
    {
        public UpdateQuantidadeOutput(ItemCarrinho itemPedido, CarrinhoCliente carrinhoCliente)
        {
            ItemPedido = itemPedido;
            CarrinhoCliente = carrinhoCliente;
        }

        public ItemCarrinho ItemPedido { get; }
        public CarrinhoCliente CarrinhoCliente { get; }
    }
}
