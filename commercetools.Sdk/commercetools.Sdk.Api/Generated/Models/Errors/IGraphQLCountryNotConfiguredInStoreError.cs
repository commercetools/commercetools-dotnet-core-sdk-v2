using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLCountryNotConfiguredInStoreError))]
    public partial interface IGraphQLCountryNotConfiguredInStoreError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IList<string> StoreCountries { get; set; }
        IEnumerable<string> StoreCountriesEnumerable { set => StoreCountries = value.ToList(); }


        string Country { get; set; }

    }
}
