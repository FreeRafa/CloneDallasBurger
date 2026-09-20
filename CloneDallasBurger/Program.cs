using CloneDallasBurger.Infraestrutura.Data;
using CloneDallasBurger.Infraestrutura.Repositorio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

IConfiguration config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

string connectionString = config.GetConnectionString("CloneDallasBurger")!;

var options = new DbContextOptionsBuilder<CloneDallasBurgerContext>()
    .UseSqlServer(connectionString)
    .LogTo(Console.WriteLine, LogLevel.Information)
    .Options;

using var context = new CloneDallasBurgerContext(options);
var categoriaRepositorio = new CategoriaRepositorio(context);

var categorias = await categoriaRepositorio.ObterTodasCategoriasAsync();
foreach (var c in categorias)
{
    Console.WriteLine($"{c.Ordem} - {c.Nome}");
}

var produtoRepositorio = new ProdutoRepositorio(context);
var produtos = await produtoRepositorio.ObterTodosProdutosAsync();
Console.WriteLine($"Produtos lidos: {produtos.Count}");

var produtoIngredienteRepositorio = new ProdutoIngredienteRepositorio(context);
var ligacoes = await produtoIngredienteRepositorio.ObterTodosProdutosIngredientesAsync();
Console.WriteLine($"Ligações lidas: {ligacoes.Count}");

var mesaRepositorio = new MesaRepositorio(context);
var mesas = await mesaRepositorio.ObterTodasMesasAsync();
Console.WriteLine($"Mesas lidas: {mesas.Count}");

var pedidoRepositorio = new PedidoRepositorio(context);
var pedidos = await pedidoRepositorio.ObterTodosPedidosAsync();
Console.WriteLine($"Pedidos lidos: {pedidos.Count}");

var burgers = await produtoRepositorio.ObterProdutosPorCategoriaAsync(1);
Console.WriteLine($"Burgers: {burgers.Count}");

var pedidoAberto = await pedidoRepositorio.ObterPedidoAbertoPorMesaAsync(1);
Console.WriteLine(pedidoAberto is null
    ? "Mesa 1 sem pedido aberto"
    : $"Pedido {pedidoAberto.PedidoId} aberto na mesa 1");