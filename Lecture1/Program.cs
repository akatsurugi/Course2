namespace Lecture1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            

            // Add services to the container.

            // builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            //builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen();

            var app = builder.Build();
           

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            //    app.UseSwagger();
            //    app.UseSwaggerUI();
            //}

            //app.UseHttpsRedirection();

            //app.UseAuthorization();


            //app.MapControllers();

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