using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TechnicalTestWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegistrationsController : ControllerBase
    {
        private readonly ILogger<RegistrationsController> _logger;

        public RegistrationsController(ILogger<RegistrationsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "App Running...";
        }

        //[HttpGet("{id:int}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return _context.Addresses.Find(id).ToString();
        //}

        //[HttpPost]
        //public ActionResult<int> Post(Address address)
        //{
        //    _context.Addresses.Add(address);
        //    _context.SaveChanges();

        //    return address.AddressId;
        //}
    }
}
