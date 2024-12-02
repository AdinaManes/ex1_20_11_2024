﻿using ex2.Services.Logger;

namespace TasksApi.Services.Logger
{
    public class LoggerFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public LoggerFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public ILoggerService GetLogger(int whereToLog)
        {
            if (whereToLog==1)
            {
                return _serviceProvider.GetRequiredService<ILoggerService>();
            }
            if (whereToLog == 2)
            {
                return _serviceProvider.GetRequiredService<FileLoggerService>();
            }
            else
                return _serviceProvider.GetRequiredService<DBLoggerService>();
        }
    }
}