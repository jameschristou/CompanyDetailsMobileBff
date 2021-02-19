using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyDetailsMobileBff.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyDetailsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CompanyDetailsController> _logger;

        public CompanyDetailsController(ILogger<CompanyDetailsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<CompanyDetails> Get()
        {
            return new List<CompanyDetails>
            {
                new CompanyDetails
                {
                    Name = "Google",
                    AddressFormatted = ""
                },
                new CompanyDetails
                {
                    Name = "Slack",
                    AddressFormatted = ""
                }
            };
        }
    }
}
