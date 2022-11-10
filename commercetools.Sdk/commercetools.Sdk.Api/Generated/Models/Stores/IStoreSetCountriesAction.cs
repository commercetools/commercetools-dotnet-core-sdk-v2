using commercetools.Sdk.Api.Models.StoreCountries;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreSetCountriesAction))]
    public partial interface IStoreSetCountriesAction : IStoreUpdateAction
    {
        List<IStoreCountry> Countries { get; set; }

    }
}
