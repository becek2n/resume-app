using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Resume.DAO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : ControllerBase
    {
        
        private readonly ILogger<ProfileController> _logger;
        private readonly IProfile _profile;
        public ProfileController(ILogger<ProfileController> logger, IProfile profile)
        {
            _logger = logger;
            _profile = profile;
        }

        [HttpGet]
        public async Task<ActionResult> Get(Guid userId)
        {
            try
            {
                _logger.LogInformation("Request is process...");
                var data = await _profile.Get(userId);

                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex}");
                return StatusCode(500, ex);
            }

        }
    }
}
