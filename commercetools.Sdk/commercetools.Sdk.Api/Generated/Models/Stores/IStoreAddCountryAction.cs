using commercetools.Sdk.Api.Models.StoreCountries;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StoreAddCountryAction))]
    public partial interface IStoreAddCountryAction : IStoreUpdateAction
    {
        IStoreCountry Country { get; set; }

    }
}
