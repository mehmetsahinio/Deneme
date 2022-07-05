using SahinBankApp.Business.Abstract;
using SahinBankApp.Business.Concrete;
using SahinBankApp.Data.Abstract;
using SahinBankApp.Data.Concrete.EFCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var app = builder.Build();
builder.Services.AddScoped<IActionMoveRepository,EfCoreActionMoveRepository>();
builder.Services.AddScoped<IActionTypeRepository,EfCoreActionTypeRepository>();
builder.Services.AddScoped<IInvoiceRepository, EfCoreInvoiceRepository>();
builder.Services.AddScoped<IActionTypeService, ActionTypeManager>();
builder.Services.AddScoped<IInvoiceService, InvoiceManager>();
builder.Services.AddScoped<IActionMoveService, ActionMoveManager>();
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

