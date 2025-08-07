using Questions.Web;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddProgram(builder.Configuration);


WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options => options.SwaggerEndpoint("/openapi/v1.json", "Questions"));
}

app.MapControllers();

app.Run();
