using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basket.Model;

namespace Basket.Repository
{
    public class BasketRepository
    {
        private static readonly List<Item> Carrinho = new(){
            new Item(){
                Id = 1,
                Nome = "Lápis",
                Quantidade = 1,
                Valor = 2
            },
            new Item(){
                Id = 2,
                Nome = "Borracga",
                Quantidade = 2,
                Valor = 0.5
            },
            new Item(){
                Id = 3,
                Nome = "Caneta",
                Quantidade = 3,
                Valor = 3.5
            } 
        };

        public void AdicionarItem(Item item){
            Carrinho.Add(item);
        }

        public IEnumerable<Item> GetCarrinho(){
            return Carrinho;
        }

        public Item? GetById(int id){
            return Carrinho.Find(e => e.Id == id);
        }
    }
}