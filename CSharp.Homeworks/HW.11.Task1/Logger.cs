using Serilog;

namespace HW._11.Task1;

public class Logger
{
    public static void CreateLogger()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.Console().WriteTo.File(
                "/Users/kate/RiderProjects/hw_dotnet/CSharp.Homeworks/HW.11.Task1/Logs/logs.txt",
                rollingInterval: RollingInterval.Hour)
            .CreateLogger();
    }
}