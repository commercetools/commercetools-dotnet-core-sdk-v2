using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.TaxedItemPrice))]
    public partial interface ITaxedItemPrice
    {
        ICentPrecisionMoney TotalNet { get; set; }

        ICentPrecisionMoney TotalGross { get; set; }

        ICentPrecisionMoney TotalTax { get; set; }

    }
}
