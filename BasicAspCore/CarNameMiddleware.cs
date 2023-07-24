namespace Lecture1
{
    public class CarNameMiddleware
    {
        private readonly RequestDelegate requestDelegate;
        public CarNameMiddleware(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var carManagement = new ManagementCars();

            var path = context.Request.Path.ToString();

            if (path == "/carName")
            {
                context.Response.StatusCode = 200;
                await context.Response.WriteAsync(carManagement.GetCarName());
            }
            else
            {
                await requestDelegate.Invoke(context);
            }
            
        }
    }

    public class CarEngineMiddleware
    {
        private readonly RequestDelegate requestDelegate;
        public CarEngineMiddleware(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var carManagement = new ManagementCars();

            var path = context.Request.Path.ToString();

            if (path == "/carEngine")
            {
                context.Response.StatusCode = 200;
                await context.Response.WriteAsync(carManagement.GetCarEngine());
            }
            else
            {
                await requestDelegate.Invoke(context);
            }

        }
    }

    public class CarAgeMiddleware
    {
        private readonly RequestDelegate requestDelegate;
        public CarAgeMiddleware(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var carManagement = new ManagementCars();

            var path = context.Request.Path.ToString();

            if (path == "/carAge")
            {
                context.Response.StatusCode = 200;
                await context.Response.WriteAsync(carManagement.GetCarAge().ToString());
            }
            else
            {
                await requestDelegate.Invoke(context);
            }

        }
    }
}