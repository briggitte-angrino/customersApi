using Serilog.Events;

namespace Cross.Logging
{
    public interface ILoggingManager
    {
        void LogDebug(string message);
        void LogDebug<T0, T1>(string message, T0 propertyValue0, T1 propertyValue1);
        void LogInformation(string message);
        void LogInformation<T0, T1>(string message, T0 propertyValue0, T1 propertyValue1);
        void LogWarning(string message);
        void LogWarning<T0, T1>(string message, T0 propertyValue0, T1 propertyValue1);
        void LogError(string message);
        void LogError<T0, T1>(string message, T0 propertyValue0, T1 propertyValue1);
        void LogWrite(LogEventLevel logEventLevel, string message, object data);
        void LogWrite<T0, T1>(LogEventLevel logEventLevel, string message, T0 propertyValue0, T1 propertyValue1);
    }
}
