using CloneDallasBurger.Apresentacao;
using CloneDallasBurger.Infraestrutura.Data;
using CloneDallasBurger.Infraestrutura.Repositorio;
using CloneDallasBurger.Modelo.Interfaces;
using CloneDallasBurger.Servico;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


IConfiguration config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

string connectionString = config.GetConnectionString("CloneDallasBurger")!;

var services = new ServiceCollection();

services.AddDbContext<CloneDallasBurgerContext>(options =>
    options.UseSqlServer(connectionString));

services.AddScoped<IFuncionarioRepositorio, FuncionarioRepositorio>();
services.AddScoped<ICategoriaRepositorio, CategoriaRepositorio>();
services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
services.AddScoped<IMesaRepositorio, MesaRepositorio>();
services.AddScoped<IPedidoRepositorio, PedidoRepositorio>();
services.AddScoped<IProdutoIngredienteRepositorio, ProdutoIngredienteRepositorio>();
services.AddScoped<MesaServico>();
services.AddScoped<RealizarPedido>();

services.AddScoped<FuncionarioServico>();
services.AddScoped<RealizarPedido>();

using var provider = services.BuildServiceProvider();
using var scope = provider.CreateScope();

var realizarPedido = scope.ServiceProvider.GetRequiredService<RealizarPedido>();
await realizarPedido.IniciarPedido();