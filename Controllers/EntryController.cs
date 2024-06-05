using addressBookAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace addressBookAPI.Controllers
{
    [ApiController]
    [Route("address-book")]
    public class EntryController(EntryService _entryService) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetNumber()
        {
            return Ok(_entryService.GetEntry());

        }
    }
}
