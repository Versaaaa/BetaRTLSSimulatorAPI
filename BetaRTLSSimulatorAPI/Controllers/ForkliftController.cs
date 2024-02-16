using Microsoft.AspNetCore.Mvc;

namespace BetaRTLSSimulatorAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ForkliftController : ControllerBase
    {
        private readonly ILogger<ForkliftController> _logger;
        private PositionNotification _positionNotification;

        public ForkliftController(ILogger<ForkliftController> logger, PositionNotification positionInformation)
        {
            _logger = logger;
            _positionNotification = positionInformation;
        }

        [HttpGet("GetPosition")]
        public IActionResult GetPosition()
        {
            return Ok(_positionNotification);
        }

        [HttpPut("PutPosition")]
        public IActionResult SetPosition([FromBody] PositionNotification req)
        {
            _positionNotification.Copy(req);
            return Ok(_positionNotification);
        }
    }
}