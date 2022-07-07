using PizzariaCSharp.Controller;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository;

Console.WriteLine("Simulando API");
Console.WriteLine();


var controllerBebida = new BebidaController(new BebidaRepository());

// Simulando a API.

// 1o Cadastrar duas Bebidas.
var bebida1 = controllerBebida.Adicionar(new Bebida("Coca Cola 2L", 10.0));
var bebida2 = controllerBebida.Adicionar(new Bebida("H2O Limoneto", 10.0));

//2o Obter todas as bebidas.
var bebidas = controllerBebida.ObterTodos();

//3 Obter bebidas por id
var bebida3 = controllerBebida.Obter(bebida1.Id);

//4o Atualizar uma bebida.
bebida2.Valor = 8.99;
controllerBebida.Atualizar(bebida2.Id, bebida2);

//5o Deletar uma Bebida
controllerBebida.Deletar(bebida1.Id);

var resultado = controllerBebida.ObterTodos();
