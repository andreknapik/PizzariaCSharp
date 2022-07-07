using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class ClienteRepository : ICrudRepository<Cliente>
    {
        public Cliente Adicionar(Cliente modelo)
        {
            throw new NotImplementedException();
        }

        public Cliente Atualizar(Cliente modelo)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public Cliente Obter(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}