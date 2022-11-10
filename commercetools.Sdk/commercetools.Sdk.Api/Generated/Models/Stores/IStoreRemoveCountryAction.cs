using commercetools.Sdk.Api.Models.StoreCountries;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreRemoveCountryAction))]
    public partial interface IStoreRemoveCountryAction : IStoreUpdateAction
    {
        IStoreCountry Country { get; set; }

    }
}
