using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzariaCSharp.Repository.Interfaces
{
    /// <summary>
    /// Interface do repositório genérico baseado na construção do modelo.
    /// </summary>
    /// <typeparam name="T">Modelo, entidade a qual será persistida.</typeparam>

    public interface ICrudRepository<T>
    {        
        /// <summary>
        /// /Metodo que adiciona um modelo ao banco de dados.
        /// </summary>
        /// <param name="modelo">Modelo que será adicionado.</param>
        /// <returns>Retorna o modelo após ser adicionado no banco de dados.</returns>
        T Adicionar(T modelo);
        /// <summary>
        /// Método que retorna uma lista com todos os modelos encontrados no banco de dados.
        /// </summary>
        /// <returns>retorna lista com todos os modelos.</returns>
        List<T> ObterTodos();
        /// <summary>
        /// Metodo que retorna o modelo enmcontrado pelo seu id.
        /// </summary>
        /// <param name="id">Id o modelo a ser encontrado</param>
        /// <returns>Retorna o modelo encontrado pelo Id.</returns>
        T Obter(int id);
        /// <summary>
        /// Metodo para atualizar um modelo no banco de dados.
        /// </summary>
        /// <param name="modelo">Modelo a ser atualizado.</param>
        /// <returns>Retorna o modelo após atualizaçao.</returns>
        T Atualizar(T modelo);
        /// <summary>
        /// Deleta o modelo pelo seu ID.
        /// </summary>
        /// <param name="id">Id do modelo que será deletado.</param>
        void Deletar(int id);
    


    }
}