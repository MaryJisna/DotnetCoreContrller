using DotnetCoreContrller.Controllers; //dependency injection 
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
//app.UseRouting();
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllers();
//});
//app.MapGet("/", () => "Hello World!");

app.Run();
