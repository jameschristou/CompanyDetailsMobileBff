namespace CompanyDetailsMobileBff.Features.Shared
{
    public class CompanyDetails
    {
        public string Name { get; set; }
        public Address Address { get; set; }

    }

    public class Address
    {
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string Locality { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
