using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class PizzaRepository : ICrudRepository<Pizza>
    {
        public Pizza Adicionar(Pizza modelo)
        {
            throw new NotImplementedException();
        }

        public Pizza Atualizar(Pizza modelo)
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