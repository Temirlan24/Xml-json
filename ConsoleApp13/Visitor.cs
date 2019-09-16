using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    public class Visitor
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime EnterTime { get; set; }
        public DateTime? ExitTime { get; set; } = null;
    }
}
