using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaCSharp.Controller.Interfaces
{
    public interface ICrudController<T>
    {
    T Adicionar(T modelo);
    List<T> ObterTodos();
    T Obter(int id);
    T Atualizar(int id, T modelo);
    void Deletar(int id);

    }
}