var webApplicationOprions =
    new WebApplicationOptions()
    {
        EnvironmentName = Microsoft.Extensions.Hosting.Environments.Development
    };

var builder = WebApplication.CreateBuilder(webApplicationOprions);

builder.Services.AddRazorPages();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Errors/Error");
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();

app.Run();

