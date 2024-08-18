using GameStore.api.Data;
using GameStore.api.dtos;
using GameStore.api.Endpoints;
using GameStore.api.Entities;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("GameStore");
builder.Services.AddSqlite<GameStoreContext>(connString);


var app = builder.Build();

app.MapGameEndpoints();
app.MapGenresEndpoints();

await app.MigrateDbAsync();


app.Run();
