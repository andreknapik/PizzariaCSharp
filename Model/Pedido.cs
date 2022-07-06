using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaCSharp.Model
{
    public class Pedido
    {
        public int Id {get; private set;}
        public DateTime DataEHora {get;private set;}
        public Cliente Cliente {get;private set;}
        public List<Pizza> Pizzas {get;private set;}
        public List<Bebida> Bebidas {get; private set;}
        
        
    }
}