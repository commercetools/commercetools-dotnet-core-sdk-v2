using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class CountryNotConfiguredInStoreError : ICountryNotConfiguredInStoreError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IList<string> StoreCountries { get; set; }

        public IEnumerable<string> StoreCountriesEnumerable { set => StoreCountries = value.ToList(); }

        public string Country { get; set; }
        public CountryNotConfiguredInStoreError()
        {
            this.Code = "CountryNotConfiguredInStore";
        }
    }
}
