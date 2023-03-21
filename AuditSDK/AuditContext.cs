using BaseObjects;
using Microsoft.Extensions.Options;

namespace AuditSDK
{
    public class AuditContext : SDKContextBase
    {
        public bool SimulateOnly { get; set; }
        public string SourceService { get; set; }

        public AuditContext(IOptions<AuditOptions> options) : base(options)
        {
            APIEndPoint = options.Value.APIEndPoint;
            Token = options.Value.APIToken;
            SimulateOnly = options.Value.SimulateOnly;
            SourceService = options.Value.SourceService;
        }
    }
}