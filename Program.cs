using DevExpress.AspNetCore;
using DevExpress.XtraReports.Native;
using DevExtremeAspNetCoreApp3.Helpers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDevExpressControls();

// Add services to the container.
builder.Services
    .AddRazorPages()
    .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

var app = builder.Build();
app.UseDevExpressControls();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

DevExpress.Utils.DeserializationSettings.RegisterTrustedClass(typeof(CustomParameterType));
SerializationService.RegisterSerializer(CustomDataSerializer.Name, new CustomDataSerializer());

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();
app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=SampleDataController}/{action=Viewer2}/{param?}");
app.MapRazorPages();

app.Run();
