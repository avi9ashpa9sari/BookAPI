using BookAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    public class WriterController : ControllerBase
    {
        public WriterController(WriterContext writerContext)
        {

        }
        [HttpGet("[action]")]
        public async Task<IActionResult> WriterDetails(int Id)
        {
            return Ok();
        }
    }
}
