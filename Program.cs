using ProvaAvonale.Data;
using ProvaAvonale.Repositories.Interfaces;
using Refit;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddRefitClient<IPagamentoRepository>().ConfigureHttpClient(c =>
	{
		c.BaseAddress = new Uri("http://sv-dev-01.pareazul.com.br:8080/");
	});
var app = builder.Build();

app.MapControllers();

app.Run();
