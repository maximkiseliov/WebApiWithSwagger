using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet("{registrationsId}")]
        public ActionResult<string> Get(Guid? registrationsId)
        {
            var registration = _context.Registrations.Include(r => r.Person).Include(r => r.Organisation);
            return _context.Registrations.Find(registrationsId.Value).ToString();
        }

        [HttpPost]
        public ActionResult<string> Post(Registration registration)
        {
            registration.RegistrationDate = DateTime.Now;
            _context.Registrations.Add(registration);
            _context.SaveChanges();

            return registration.RegistrationId.ToString();
        }
    }
}
