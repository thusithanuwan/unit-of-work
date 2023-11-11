using Microsoft.EntityFrameworkCore;
using UnitOfWork.Data;
using UnitOfWork.Repository;
using UnitOfWork.Repository.Repository;
using UnitOfWork.Service;

namespace UnitOfWork;

// Depreciated class after .Net 5
public class Startup
{
    private IConfiguration Configuration { get; }
    
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services) // This is a default method
    {
        var connectionString = Configuration.GetConnectionString("connection");
        services.AddDbContext<Context>(option =>
            option.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
        
        services.AddScoped<IStudentUnitOfWork, StudentUnitOfWork>();

        services.AddScoped<IStudentService, StudentService>();

    }
    
    
    }