using Gerenciamento_Financeiro.core.entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.EntityFrameworkCore;
using Gerenciamento_Financeiro.infrastructure.data;
using Gerenciamento_Financeiro.infrastructure.repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using Gerenciamento_Financeiro.core.enums;
using Gerenciamento_Financeiro.application.services;

var builder = WebApplication.CreateBuilder(args);

//Serviços

//Dependencias
builder.Services.AddScoped<transacaoServices>();
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

/*
app.MapPost("/AdicionarTransacao", (Transacao transacao, transacaoRepository teste) =>
{
    teste.AdicionarTransacao(transacao);
    return Results.Ok("Concluida com sucesso");
});
*/

app.MapGet("/BuscarPorData", (DateOnly DataBusca, transacaoServices t) =>
{
    var result = t.BuscarPorDataService(DataBusca);
    return Results.Ok(result);

});

app.MapGet("/BuscarPorTipoDeOperacao", (tipoOperacao tipoOperacao, transacaoServices t) =>
{
    var result = t.BuscarPorTipoDeOperacaoService(tipoOperacao);
    return Results.Ok(result);

});

app.MapGet("/BuscarPorID", (int Id, transacaoServices t) =>
{
    var result = t.BuscarPorIDService(Id);
    return Results.Ok(result);

});

app.MapPost("/AdicionarTransacao", (Transacao transacao, transacaoServices t) =>
{
    t.AdicionarTransacaoService(transacao);
    return Results.Ok("Concluida com sucesso");
});

app.MapPut("/ModificarTransacao", (Transacao transacao, transacaoServices t) =>
{
    t.ModificarTransacaoService(transacao);
    return Results.Ok("Concluida com sucesso");
});

app.MapDelete("/RemoverPorID", (int Id, transacaoServices t) =>
{
    t.ExcluirTransacaoPorIDService(Id);
    return Results.Ok("Concluida com sucesso");

});

app.Run();