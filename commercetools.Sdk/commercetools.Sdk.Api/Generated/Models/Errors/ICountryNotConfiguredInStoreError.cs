using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.CountryNotConfiguredInStoreError))]
    public partial interface ICountryNotConfiguredInStoreError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        IList<string> StoreCountries { get; set; }
        IEnumerable<string> StoreCountriesEnumerable { set => StoreCountries = value.ToList(); }


        string Country { get; set; }

    }
}
