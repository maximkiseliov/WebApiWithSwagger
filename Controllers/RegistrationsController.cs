using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using TechnicalTestWebApi.Models;

namespace TechnicalTestWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegistrationsController : ControllerBase
    {
        private readonly RegistrationAppDbContext _context;
        //private readonly ILogger<RegistrationsController> _logger;

        //public RegistrationsController(ILogger<RegistrationsController> logger)
        //{
        //    _logger = logger;
        //}

        public RegistrationsController(RegistrationAppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "App Running...";
        }

        [HttpGet("{id:int}")]
        public ActionResult<string> Get(int id)
        {
            return _context.Addresses.Find(id).ToString();
        }

        [HttpPost]
        public ActionResult<int> Post(Registration registration)
        {
            registration.RegistrationDate = DateTime.Now;
            _context.Registrations.Add(registration);
            _context.SaveChanges();

            return registration.RegistrationId;
        }
    }
}
