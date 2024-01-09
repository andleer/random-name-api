using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.AllowAnyOrigin();
        });
});

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseDefaultFiles();
app.UseStaticFiles(new StaticFileOptions
{
    //FileProvider = new PhysicalFileProvider(
    //       Path.Combine(builder.Environment.ContentRootPath, "MyStaticFiles")),
    RequestPath = "/static"
});

app.UseCors();

//app.UseAuthorization(); 

app.MapControllers();

app.Run();
