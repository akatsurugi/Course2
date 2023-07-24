using Lecture1;

namespace BasicAspCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();
            app.UseMiddleware<CarNameMiddleware>();
            app.UseMiddleware<CarAgeMiddleware>();
            app.UseMiddleware<CarEngineMiddleware>();

            app.Run(async (context) =>
            {
                var request = context.Request;
                var response = context.Response;
                response.Headers.ContentLanguage = "en";
                response.Headers.ContentType = "text/html";
                response.StatusCode = 300;

                await response.WriteAsync($"{request.Path}");
            });

            app.Run();
        }
    }
}