using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzariaCSharp.Model;

namespace PizzariaCSharp.Repository.Interfaces
{
public class SaborRepository : ICrudRepository<Sabor>
    {
        private  List<Sabor> _sabores;
        private int _ultimoId = 0;

        public SaborRepository()
        {
           _sabores = new List<Sabor>();
        }

        public Sabor Adicionar(Sabor sabor)
        {
            _ultimoId++;
            sabor.Id = _ultimoId;

            _sabores.Add(sabor);

            return sabor;
        }

        public List<Sabor> ObterTodos()
        {
            return _sabores;
        }
        public Sabor Obter(int id)
        {
           return _sabores
           .Where(b => b.Id == id)
           .FirstOrDefault();
        }

        public Sabor Atualizar(Sabor sabor)
        {
            var saborEncontrada = _sabores.Where(b => b.Id == sabor.Id).FirstOrDefault();

            if(saborEncontrada == null)
            { 
                throw new Exception("Não é possível atualizar uma sabor que não exista.");
            }

           _sabores.Remove(saborEncontrada);
            _sabores.Add(saborEncontrada);

            return sabor;
        }

        public void Deletar(int id)
        {
            var sabor = Obter(id);
            if(sabor == null)
            {
                throw new Exception("Não foi encontrada uma bebida com o ID "+ id);
            }

           _sabores.Remove(sabor);
        }




        /* CRUD
        Create, Read, Update, Delete
        */
    }
}