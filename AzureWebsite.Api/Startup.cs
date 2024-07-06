public void ConfigureServices(IServiceCollection services)
{
    services.AddControllers();
    services.AddDbContext<MyDbContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
    // Dodanie innych usług
}