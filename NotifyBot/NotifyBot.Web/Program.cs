using NotifyBot.CrossCutting.IoC;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

builder.Services.ApplyApiConfigurations(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
