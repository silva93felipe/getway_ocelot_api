using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basket.Model;

namespace Basket.Repository
{
    public class BasketRepository
    {
        private static readonly Carrinho Carrinho = new()
        {
          Id = 1,
        };

        public void AdicionarItem(Item item){
            Carrinho.AdicionarItens(item);
        }

        public Carrinho GetCarrinho(){
            return Carrinho;
        }
    }
}