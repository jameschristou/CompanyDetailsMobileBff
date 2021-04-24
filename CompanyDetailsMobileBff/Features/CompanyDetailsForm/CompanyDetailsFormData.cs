using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyDetailsMobileBff.Features.CompanyDetailsForm
{
    public class CompanyDetailsFormData
    {
        public Guid Id { get; set; }
        public FormTextField CompanyName { get; set; }
    }

    public class FormTextField
    {
        public string CurrentValue { get; set; }
        public string FieldName { get; set; }
        public string FieldLabel { get; set; }

        // client side validation

        // server side validation
    }
}
