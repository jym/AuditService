using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditSDK
{
    public static class AuditExtensions
    {
        public static IServiceCollection AddAudits(this IServiceCollection collection, Action<AuditOptions> options)
        {
            return collection.AddScoped<AuditContext>().Configure<AuditOptions>(options);
        }
    }
}
