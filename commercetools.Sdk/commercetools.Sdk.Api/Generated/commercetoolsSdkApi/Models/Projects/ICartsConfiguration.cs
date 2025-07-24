using commercetools.Sdk.Api.Models.Carts;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Projects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Projects.CartsConfiguration))]
    public partial interface ICartsConfiguration
    {
        int? DeleteDaysAfterLastModification { get; set; }

        bool? CountryTaxRateFallbackEnabled { get; set; }

        IRoundingMode PriceRoundingMode { get; set; }

        IRoundingMode TaxRoundingMode { get; set; }

    }
}
