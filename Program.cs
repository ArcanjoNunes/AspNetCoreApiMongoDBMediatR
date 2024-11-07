var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();

builder.Services.Configure<MongoDBDatabaseSettings>
    (
        builder.Configuration.GetSection("MongoDBDatabaseSettings")
    );

builder.Services.AddSingleton<IMongoClient>(_ =>
{
    var connectionString =
        builder
            .Configuration
            .GetSection("MongoDBDatabaseSettings:ConnectionString")?
            .Value;
    return new MongoClient(connectionString);
});

builder.Services.AddScoped<DBCollection>();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));


var app = builder.Build();

app.MapControllers();

app.MapParticipantEndpoints();
app.MapBeneficiaryEndpoints();

app.UseHttpsRedirection();

app.MapGet("/", () => "MongoDB.Mediatr.CQRS.Participants Server is running.");

app.Run();

/// <summary>
/// Used in xUnit Test
/// </summary>
public partial class Program { }