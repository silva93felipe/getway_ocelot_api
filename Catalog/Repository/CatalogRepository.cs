using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.Model;

namespace Catalog.Repository
{
    public class CatalogRepository
    {
         private static readonly List<Item> Catalog = new(){
            new Item(){
                Id = 1,
                Nome = "Lápis",
                Categoria = new Categoria()
                {
                    Id = 1,
                    Descricao = "Material Escolar"
                }
            },
            new Item(){
                Id = 2,
                Nome = "Borracha",
                Categoria = new Categoria()
                {
                    Id = 1,
                    Descricao = "Material Escolar"
                }
                
            },
            new Item(){
                Id = 3,
                Nome = "Caneta",
                Categoria = new Categoria()
                {
                    Id = 1,
                    Descricao = "Material Escolar"
                }
            },
             new Item(){
                Id = 4,
                Nome = "Lapizeira",
                Categoria = new Categoria()
                {
                    Id = 1,
                    Descricao = "Material Escolar"
                }
            },
            new Item(){
                Id = 5,
                Nome = "Caderno",
                Categoria = new Categoria()
                {
                    Id = 2,
                    Descricao = "Papelaria"
                }
            },
            new Item(){
                Id = 6,
                Nome = "Coleção",
                Categoria = new Categoria()
                {
                    Id = 1,
                    Descricao = "Material Escolar"
                }
            } 
        };

        public void AdicionarItem(Item item){
            Catalog.Add(item);
        }

        public IEnumerable<Item> GetCarrinho(){
            return Catalog;
        }

        
        public IEnumerable<Item> ByCategoria(int categoriaId){
            return Catalog.Where(i => i.Categoria.Id == categoriaId);
        }
    }
}