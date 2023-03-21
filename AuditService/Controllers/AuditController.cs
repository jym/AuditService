using Base.Objects;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AuditService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class AuditController : ControllerBase
    {       
        private readonly AuthInfo _authInfo;
        private readonly IConfiguration _config;

        public AuditController(AuthInfo ai, IConfiguration config)
        {            
            _authInfo = ai;
            _config = config;
        }
    }
}
