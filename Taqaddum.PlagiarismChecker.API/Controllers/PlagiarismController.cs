using Microsoft.AspNetCore.Mvc;
using Taqaddum.PlagiarismChecker.API.Models;

namespace Taqaddum.PlagiarismChecker.API.Controllers
{
    [ApiController]
    [Route("plagiarism")]
    public class PlagiarismController : ControllerBase
    {
        private ILogger<PlagiarismController> _logger;

        public PlagiarismController(ILogger<PlagiarismController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult> Post(FileReq request)
        {
            return Ok();
        }
    }
}
