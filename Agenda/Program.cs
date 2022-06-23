using Agenda.Data;
using Agenda.ViewModels;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("v1/tarefas", (AppDbContext ctx) => {

    var tarefas = ctx.Tarefas.ToList();

    return Results.Ok(tarefas); // options: Ok(), BadRequest(), NotFound(), NoContent()...
}).Produces<Tarefa>();

app.MapPost("v1/tarefas", (
    AppDbContext ctx,
    CriarTarefaViewModel mdl) => {

        var tarefa = mdl.MapTo();
        if (!mdl.IsValid)
        return Results.BadRequest(mdl.Notifications);

        ctx.Tarefas.Add(tarefa);
        ctx.SaveChanges();

        return Results.Created($"/v1/tarefas/{tarefa.Id}", tarefa);

     // options: Ok(), BadRequest(), NotFound(), NoContent()...
});


app.Run();

