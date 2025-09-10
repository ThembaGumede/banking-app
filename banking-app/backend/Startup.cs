/*
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();

        // Register Swagger generator
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
            {
                Title = "Banking API",
                Version = "v1",
                Description = "API for managing banking operations"
            });
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseDeveloperExceptionPage();

            // Enable Swagger middleware
            app.UseSwagger();

            // Enable Swagger UI
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Banking API V1");
                c.RoutePrefix = string.Empty; // Optional: serve Swagger UI at root
            });
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();
        app.UseAuthentication();
        
        app.UseAuthorization();
       
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
*/