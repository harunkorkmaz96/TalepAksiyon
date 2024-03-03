using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using TalepAksiyon.Infasctructure.Registiration;
using TalepAksiyon.Infasctructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddNewtonsoftJson(nsj =>
{
  nsj.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
  nsj.SerializerSettings.ContractResolver = new DefaultContractResolver
  {
    NamingStrategy = new DefaultNamingStrategy()
  };
}).AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null).AddRazorRuntimeCompilation();

builder.Services.AddSession(opt =>
{
  opt.IdleTimeout = TimeSpan.FromMinutes(20);
});
string connString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDataBase(connString);
builder.Services.MyRepository();

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
app.UseSession();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Security}/{action=Login}/{id?}");

app.Run();
