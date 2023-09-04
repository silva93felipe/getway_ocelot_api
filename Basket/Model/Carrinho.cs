using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.Model
{
    public class Carrinho
    {
        public int Id { get; set; }
        private List<Item> Itens { get; set; }

        public Carrinho()
        {
            Itens = new List<Item>(){
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

        }

        public void AdicionarItens(Item item){
            Itens.Add(item);
        }
    }
}