using Microsoft.AspNetCore.Mvc;

namespace MarkdownEditor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<FileController> _logger;

        public FileController(ILogger<FileController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetHelloWorld")]
        public string GetHelloWorld()
        {
            return "Hello World";
        }
    }
}
