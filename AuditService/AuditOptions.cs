using BaseObjects;
using System;

namespace AuditService
{
    public class AuditOptions : SDKOptionsBase
    {
        public bool SimulateOnly { get; set; } = false;
        public string SourceService { get; set; } = String.Empty;
    }
}
