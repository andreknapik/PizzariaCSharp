using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzariaCSharp.Model;

namespace PizzariaCSharp.Controller.Interfaces
{
    public class PedidoController : ICrudController<Pedido>
    {
        public Pedido Adicionar(Pedido modelo)
        {
            throw new NotImplementedException();
        }

        public Pedido Atualizar(int id, Pedido modelo)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public Pedido Obter(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pedido> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}