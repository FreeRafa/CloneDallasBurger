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

//var produtoRepositorio = new ProdutoRepositorio(context);
//var produtos = await produtoRepositorio.ObterTodosProdutosAsync();
//Console.WriteLine($"Produtos lidos: {produtos.Count}");