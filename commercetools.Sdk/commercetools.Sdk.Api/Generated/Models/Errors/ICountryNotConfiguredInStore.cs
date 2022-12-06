using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.CountryNotConfiguredInStore))]
    public partial interface ICountryNotConfiguredInStore : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        List<string> StoreCountries { get; set; }

        string Country { get; set; }

    }
}
