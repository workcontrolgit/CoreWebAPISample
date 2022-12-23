using Serilog;

try
{
    var builder = WebApplication.CreateBuilder(args);
    //var logger = new LoggerConfiguration()
    //                    .ReadFrom.Configuration(builder.Configuration)
    //                    .Enrich.FromLogContext()
    //                    .CreateLogger();
    //builder.Host.UseSerilog(logger);


    Log.Logger = new LoggerConfiguration()
                    .ReadFrom.Configuration(builder.Configuration)
                    //.SetSerilogPlusDefaultConfiguration()
                    .Enrich.FromLogContext()
                    .CreateLogger();
    // builder.Host.UseSerilogPlus();
    builder.Host.UseSerilog(Log.Logger);

    // more configuration

    // Add services to the container.

    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();


    var app = builder.Build();
    //app.UseSerilogPlusRequestLogging();
    // app.UseSerilogPlusRequestLogging();
    // app.UseSerilogRequestLogging

    // more configs

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();


    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Unhandled exception");
}
finally
{
    Log.Information("Shut down complete");
    Log.CloseAndFlush();
}