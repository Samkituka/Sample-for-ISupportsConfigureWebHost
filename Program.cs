namespace Project_WebHost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHost(builder =>
                {
                    builder.UseKestrel();
                    builder.UseUrls("http://localhost:7134");
                    builder.UseStartup<Startup>();
                });
    }
}