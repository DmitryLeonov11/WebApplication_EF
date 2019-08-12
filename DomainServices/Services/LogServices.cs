using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Interfaces;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices.Services
{
    public class LogServices : ILogService
    {
        private readonly ILogRepository _logRepository;

        public LogServices (ILogRepository logRepository)
        {
            _logRepository = logRepository;
        }

        public void LogRequest(RequestInfo requestInfo)
        {
            _logRepository.Insert(new RequestLogEntry()
            {
                ClientIP = requestInfo.ClientIP,
                Controller = requestInfo.Controller,
                Request = requestInfo.Request
            });
        }
    }
}
