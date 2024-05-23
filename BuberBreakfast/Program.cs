using BuberBreakfast.Services.Breakfasts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddSingleton<IBreakfastService, BreakfastService>();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();


app.Run();