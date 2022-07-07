using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Model;

namespace PizzariaCSharp.Controller
{
    public class ClienteController : ICrudController<Cliente>
    {
        public Cliente Adicionar(Cliente modelo)
        {
            throw new NotImplementedException();
        }

        public Cliente Atualizar(int id, Cliente modelo)
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