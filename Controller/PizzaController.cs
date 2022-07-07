using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Model;

namespace PizzariaCSharp.Controller
{
    public class PizzaController : ICrudController<Pizza>
    {
        public Pizza Adicionar(Pizza modelo)
        {
            throw new NotImplementedException();
        }

        public Pizza Atualizar(int id, Pizza modelo)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public Pizza Obter(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pizza> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}