using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository.Interfaces;

namespace PizzariaCSharp.Repository
{
    public class BebidaRepository : ICrudRepository<Bebida>
    {
        private  List<Bebida> _bebidas;
        private int _ultimoId = 0;

        public BebidaRepository()
        {
            _bebidas = new List<Bebida>();
        }

        public Bebida Adicionar(Bebida bebida)
        {
            _ultimoId++;
            bebida.Id = _ultimoId;

            _bebidas.Add(bebida);

            return bebida;
        }

        public List<Bebida> ObterTodos()
        {
            return _bebidas;
        }
        public Bebida Obter(int id)
        {
           return _bebidas
           .Where(b => b.Id == id)
           .FirstOrDefault();
        }

        public Bebida Atualizar(Bebida bebida)
        {
            var bebidaEncontrada = _bebidas.Where(b => b.Id == bebida.Id).FirstOrDefault();

            if(bebidaEncontrada == null)
            { 
                throw new Exception("Não é possível atualizar uma bebida que não exista.");
            }

            _bebidas.Remove(bebidaEncontrada);
            _bebidas.Add(bebidaEncontrada);

            return bebida;
        }

        public void Deletar(int id)
        {
            var bebida = Obter(id);
            if(bebida == null)
            {
                throw new Exception("Não foi encontrada uma bebida com o ID "+ id);
            }

            _bebidas.Remove(bebida);
        }




        /* CRUD
        Create, Read, Update, Delete
        */
    }
}