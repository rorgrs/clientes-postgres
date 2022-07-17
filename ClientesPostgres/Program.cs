using ClientesPostgres.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! //
// Mude as opcoes de conexao conforme o seu banco de dados //
// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! //
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<Contexto>(options =>
    options.UseNpgsql("Host=localhost;Port=5432;Pooling=true;Database=USEALL_CLIENTES;User Id=postgres;Password=12345"));
// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! //
// Mude o nome da Database como preferir //
// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! //

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
