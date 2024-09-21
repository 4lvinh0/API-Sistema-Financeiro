using Gerenciamento_Financeiro.core.entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.EntityFrameworkCore;
using Gerenciamento_Financeiro.infrastructure.data;
using Gerenciamento_Financeiro.infrastructure.repositories;
using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);

    //Serviços

//Dependencias
builder.Services.AddScoped<transacaoRepository>();

//Banco de Dados
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));

//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.MapGet("/", () => "Hello World!");


app.MapPost("/AdicionarTransacao", (Transacao transacao, transacaoRepository teste) =>
{ 
    teste.AdicionarTransacao(transacao);
    return Results.Ok("Concluida com sucesso");
});




app.Run();