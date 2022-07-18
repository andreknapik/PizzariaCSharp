using PizzariaCSharp.Controller;
using PizzariaCSharp.Controller.Interfaces;
using PizzariaCSharp.Enums;
using PizzariaCSharp.Model;
using PizzariaCSharp.Repository;
using PizzariaCSharp.Repository.Interfaces;

Console.WriteLine("Simulando API");
Console.WriteLine();


var controllerBebida = new BebidaController(new BebidaRepository());
var controllerSabor = new SaborController(new SaborRepository());
var controllerPizza = new PizzaController(new PizzaRepository());
var controllerCliente = new ClienteController(new ClienteRepository());
var controllerPedido = new PedidoController(new PedidoRepository());


// Simulando a API.

// 1o Cadastrar duas Bebidas.
var bebida1 = controllerBebida.Adicionar(new Bebida("Coca Cola 2L", 10.0));
var bebida2 = controllerBebida.Adicionar(new Bebida("H2O Limoneto", 10.0));

// 2o Cadastrar 4 sabores
var sabor1 = controllerSabor.Adicionar(new Sabor("4 Queijos",""));
var sabor2 = controllerSabor.Adicionar(new Sabor("Portuguesa",""));
var sabor3 = controllerSabor.Adicionar(new Sabor("Calabresa",""));
var sabor4 = controllerSabor.Adicionar(new Sabor("Frango com Catupiry",""));

// 3o Cadastrar 2 Clientes
var cliente1 = controllerCliente.Adicionar(new Cliente(){Nome= "Jose Francisco", Telefone="021999999999"});
var cliente2 = controllerCliente.Adicionar(new Cliente(){Nome= "Renato Silveira", Telefone="021999999999"});

var sabores = new List<Sabor>();

// 4o Criar Pizzas

var pizza1 = new Pizza(PizzariaCSharp.Enums.ETipoPizza.GIGANTE, ETipoBorda.COM_CHEDDAR, 40.0, new List<Sabor>{sabor1, sabor2} );
var pizza2 = new Pizza(PizzariaCSharp.Enums.ETipoPizza.SUPER_GIGANTE, ETipoBorda.COM_CHEDDAR, 40.0, new List<Sabor>{sabor2, sabor3} );
var pizza3 = new Pizza(PizzariaCSharp.Enums.ETipoPizza.MEDIA, ETipoBorda.COM_GORGONZOLA, 40.0, new List<Sabor>{sabor4} );
var pizza4 = new Pizza(PizzariaCSharp.Enums.ETipoPizza.GIGANTE, ETipoBorda.COM_MUSSARELA, 40.0, new List<Sabor>{sabor3} );


//4o Cadastrar Pedidos
var pedido1 = new Pedido(cliente1);

var valor1 = pedido1
.AdicionarBebida(bebida1)
.AdicionarBebida(bebida2)
.AdicionarPizza(pizza1)
.AdicionarPizza(pizza2)
.ObterValorTotal();

pedido1.FinalizarPedido();
controllerPedido.Adicionar(pedido1);

var pedido2 = new Pedido(cliente2);

var valor2 = pedido2
.AdicionarBebida(bebida2)
.AdicionarPizza(pizza4)
.ObterValorTotal();

pedido2.FinalizarPedido();
controllerPedido.Adicionar(pedido2);

Console.WriteLine(pedido1);
Console.WriteLine();
Console.WriteLine(pedido1);