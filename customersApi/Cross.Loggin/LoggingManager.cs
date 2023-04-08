using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Events;
using System;

namespace Cross.Logging
{
    public class LoggingManager : ILoggingManager
    {
        private readonly bool activateWritingLogs;

        public LoggingManager(IConfiguration configuration)
        {
            activateWritingLogs =
                Convert.ToBoolean(
                    configuration[
                        "ActivateLogsWriting"]); 
        }

        #region LogDebug
        public void LogDebug(string message)
        {
            if (activateWritingLogs)
            {
                Log.Logger.Debug(message);
            }
        }

        public void LogDebug<T0, T1>(string message, T0 propertyValue0, T1 propertyValue1)
        {
            if (activateWritingLogs)
            {
                Log.Logger.Write(LogEventLevel.Warning, message, propertyValue0, propertyValue1);
            }
        }
        #endregion
        
        #region LogInformation
        public void LogInformation(string message)
        {
            if (activateWritingLogs)
            {
                Log.Logger.Information(message);
            }
        }

        public void LogInformation<T0, T1>(string message, T0 propertyValue0, T1 propertyValue1)
        {
            if (activateWritingLogs)
            {
                Log.Logger.Write(LogEventLevel.Warning, message, propertyValue0, propertyValue1);
            }
        }
        #endregion

        #region LogWarning
        public void LogWarning(string message)
        {
            if (activateWritingLogs)
            {
                Log.Logger.Warning(message);
            }
        }

        public void LogWarning<T0, T1>(string message, T0 propertyValue0, T1 propertyValue1)
        {
            if (activateWritingLogs)
            {
                Log.Logger.Write(LogEventLevel.Warning, message, propertyValue0, propertyValue1);
            }
        }
        #endregion

        #region LogError
        public void LogError(string message)
        {
            if (activateWritingLogs)
            {
                Log.Logger.Error(message);
            }
        }

        public void LogError<T0, T1>(string message, T0 propertyValue0, T1 propertyValue1)
        {
            if (activateWritingLogs)
            {
                Log.Logger.Write(LogEventLevel.Warning, message, propertyValue0, propertyValue1);
            }
        }
        #endregion

        #region LogWrite
        public void LogWrite(LogEventLevel logEventLevel, string message, object data)
        {
            if (activateWritingLogs)
            {
                Log.Logger.Write(logEventLevel, message, data);
            }
        }

        public void LogWrite<T0, T1>(LogEventLevel logEventLevel, string message, T0 propertyValue0, T1 propertyValue1)
        {
            if (activateWritingLogs)
            {
                Log.Logger.Write(logEventLevel, message, propertyValue0, propertyValue1);
            }
        }
        #endregion
    }
}
