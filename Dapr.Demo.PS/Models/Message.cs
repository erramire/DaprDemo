using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dapr.Demo.PS.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public string Content  { get; set; }
        public string Subject { get; set; }
    }
}
