using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class PedidoRepository : ICrudRepository<Pedido>
    {
        public Pedido Adicionar(Pedido modelo)
        {
            throw new NotImplementedException();
        }

        public Pedido Atualizar(Pedido modelo)
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