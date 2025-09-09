using aula_02_09.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Conexão com o MongoDB
ContextMongodb.ConnectionString = builder.Configuration.GetSection("MongoConnection: ConnectionString").Value;
ContextMongodb.DatabaseName = builder.Configuration.GetSection("MongoConnection: Database").Value;
ContextMongodb.Isssl = Convert.ToBoolean(builder.Configuration.GetSection("MongoConnection: Isssl").Value);

// Configuração do Identity
builder.Services.AddIdentity<ApplicationUser, ApplicationRole>()
    .AddMongoDbStores<ApplicationUser, ApplicationRole, Guid>
    (ContextMongodb.ConnectionString, ContextMongodb.DatabaseName);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();