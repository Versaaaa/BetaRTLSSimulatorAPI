using Microsoft.AspNetCore.Mvc;

namespace BetaRTLSSimulatorAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ForkliftController : ControllerBase
    {
        private readonly ILogger<ForkliftController> _logger;
        private PositionInformation _positionInformation;

        public ForkliftController(ILogger<ForkliftController> logger, PositionInformation positionInformation)
        {
            _logger = logger;
            _positionInformation = positionInformation;
        }

        [HttpGet("GetPosition")]
        public IActionResult GetPosition()
        {
            return Ok(_positionInformation);
        }

        [HttpPut("PutPosition")]
        public IActionResult SetPosition([FromBody] PositionInformation req)
        {
            _positionInformation.Copy(req);
            return Ok(_positionInformation);
        }
    }
}