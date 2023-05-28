var builder = WebApplication.CreateBuilder(args);

//add controllers and views
builder.Services.AddControllersWithViews();

//build
var app = builder.Build();

//add static files
app.UseStaticFiles();

//use routine
app.UseRouting();

//set up routing mapping
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

//run app
app.Run();





