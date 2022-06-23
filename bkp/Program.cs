using Agenda.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();


app.MapGet("v1/tarefas", (AppDbContext ctx) => {

    var tarefas = ctx.Tarefas.ToList();

    return Results.Ok(tarefas); // options: Ok(), BadRequest(), NotFound(), NoContent()...
});

app.Run();

