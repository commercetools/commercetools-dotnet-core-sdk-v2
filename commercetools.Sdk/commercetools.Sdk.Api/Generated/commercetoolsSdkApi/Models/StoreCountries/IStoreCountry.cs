using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StoreCountries
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StoreCountries.StoreCountry))]
    public partial interface IStoreCountry
    {
        string Code { get; set; }

    }
}
