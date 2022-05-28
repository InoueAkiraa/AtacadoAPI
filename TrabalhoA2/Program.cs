using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(doc => {
    doc.SwaggerDoc("v1",
        new OpenApiInfo
        {
            Title = "Atacado API - V1",
            Version = "v1 - Pilot",
            Description = "Código desenvolvido para simular um banco de dados que possui produtos e estes mesmos possuem subcategorias e categorias, desenvolvimento de uma API Restful, desenvolvimento dos verbos HTTP, revisão de ensinamentos sintáticos/semânticos e discutido em sala de aula como otimizar esse código através do JavaScript, entre outros recursos.",
        }
    );

    var filePath = Path.Combine(System.AppContext.BaseDirectory, "AtacadoAPI.xml");
    doc.IncludeXmlComments(filePath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
