//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
public class Program
{
    private static void Main(string[] args)
    {
       
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        app.UseStaticFiles();

        app.MapControllerRoute(name: "def",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}