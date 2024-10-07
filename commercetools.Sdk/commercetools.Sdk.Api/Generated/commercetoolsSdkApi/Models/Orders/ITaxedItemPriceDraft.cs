using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.TaxedItemPriceDraft))]
    public partial interface ITaxedItemPriceDraft
    {
        IMoney TotalNet { get; set; }

        IMoney TotalGross { get; set; }

    }
}
