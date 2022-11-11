using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class CountryNotConfiguredInStore : ICountryNotConfiguredInStore
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public List<string> StoreCountries { get; set; }

        public string Country { get; set; }
        public CountryNotConfiguredInStore()
        {
            this.Code = "CountryNotConfiguredInStore";
        }
    }
}
