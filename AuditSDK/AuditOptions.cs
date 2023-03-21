using BaseObjects;
using System;

namespace AuditSDK
{
    public class AuditOptions : SDKOptionsBase
    {
        public bool SimulateOnly { get; set; } = false;
        public string SourceService { get; set; } = String.Empty;
    }
}
