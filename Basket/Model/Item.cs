using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.Model
{
    public class Item
    {
        public int Id { get; set; }
        public double Quantidade { get; set; }	
        public double Valor {get; set; }
        public string Nome { get; set; }
    }
}