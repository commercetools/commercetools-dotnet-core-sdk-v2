using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLCountryNotConfiguredInStoreError : IGraphQLCountryNotConfiguredInStoreError
    {
        public string Code { get; set; }

        public IList<string> StoreCountries { get; set; }

        public IEnumerable<string> StoreCountriesEnumerable { set => StoreCountries = value.ToList(); }

        public string Country { get; set; }
        public GraphQLCountryNotConfiguredInStoreError()
        {
            this.Code = "CountryNotConfiguredInStore";
        }
    }
}
