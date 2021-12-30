using System;
using Classwork_26._10._21.Controllers;
using Microsoft.Extensions.Logging;

namespace Classwork_26._10._21.ExceptionHandler
{
    public class ExceptionHandler
    {
        private readonly ILogger<CalcController> _logger;
        public ExceptionHandler(ILogger<CalcController> logger)
        {
            _logger = logger;
        }

        public void Handle(Exception exception)
        {
            Handle((dynamic) exception);
        }

        public void Handle(NullReferenceException exception)
        {
            _logger.LogInformation(exception.Message);
        }
        public void Handle(ArgumentException exception)
        {
            _logger.LogInformation(exception.Message);
        }
        public void Handle(InvalidOperationException exception)
        {
            _logger.LogInformation(exception.Message);
        }
    }
}