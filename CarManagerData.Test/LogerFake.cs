using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace CarManagerData.Test
{
    public class LogerFake : ILogger
    {
        public void Dispose()
        {
            //
        }
        public IDisposable BeginScope<TState>(TState state)
        {
            return this;
        }
        bool ILogger.IsEnabled(LogLevel logLevel)
        {
            return true;
        }
        void ILogger.Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            //
        }
    }
}
