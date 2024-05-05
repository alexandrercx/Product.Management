using Serilog.Events;
using Serilog;
using Serilog.Exceptions;

namespace Product.Management.Configuration
{
    public static class SerilogConfig
    {
        public static void AddSerilogApi(this IConfiguration configuration)
        {
            Log.Logger = new LoggerConfiguration()
                .Enrich.WithMachineName()
                .Enrich.FromLogContext()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Error)
                .Enrich.WithExceptionDetails()
                .WriteTo.Async(wu => wu.UdpSyslog(host: "", port: 1010, appName: "", outputTemplate: ""))
                .CreateLogger();
            Serilog.Debugging.SelfLog.Enable(Console.Error);
        }
    }
}
