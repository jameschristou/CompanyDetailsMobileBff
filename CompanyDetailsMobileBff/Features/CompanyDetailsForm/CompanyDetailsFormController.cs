using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyDetailsMobileBff.Features.CompanyDetailsForm
{
    [ApiController]
    [Route("company-details")]
    public class CompanyDetailsFormController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CompanyDetailsFormController> _logger;

        public CompanyDetailsFormController(ILogger<CompanyDetailsFormController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public CompanyDetailsFormData Get(Guid companyId)
        {
            return new CompanyDetailsFormData
            {
                Id = Guid.NewGuid(),
                CompanyName = new FormTextField { CurrentValue = "Google", FieldLabel = "Company Name", FieldName = "CompanyName" }
            };
        }
    }
}
