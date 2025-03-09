using Microsoft.Extensions.Logging;

namespace Lemao.UtilExtensions;

public static class LoggerExtensions
{
    public static void LogError(this ILogger logger, Exception exception) => logger.LogError(exception, "{Message}", exception.Message);
}
