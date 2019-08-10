﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models
{
    public class RequestLogEntry
    {
        public int Id { get; set; }
        public string ClientIP {get; set;}
        public string Controller { get; set;}
        public string Request { get; set; }
    }
}
