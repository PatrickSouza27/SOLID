using SOLID.Dados.DbContext;
using SOLID.Dados.Interfaces;
using SOLID.Services.Handles;
using SOLID.Services;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => "Hello World!");


void ConfigureServices(IServiceCollection services)
{
    services.AddTransient<ICategoriaDao, CategoriaDaoComEF>();
    services.AddTransient<ILeilaoDao, LeilaoDaoComEF>();
    services.AddTransient<IProdutoService, DefaultProdutoService>();
    //services.AddDbContext<AppDbContext>();
    //services.AddControllers()
    //    .AddNewtonsoftJson(options =>
    //    {
    //        options.SerializerSettings.ContractResolver = new DefaultContractResolver();
    //    });
}


app.Run();
