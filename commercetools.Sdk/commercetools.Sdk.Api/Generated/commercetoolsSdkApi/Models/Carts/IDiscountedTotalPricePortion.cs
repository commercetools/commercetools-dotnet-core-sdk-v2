using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.DiscountedTotalPricePortion))]
    public partial interface IDiscountedTotalPricePortion
    {
        IReference Discount { get; set; }

        ITypedMoney DiscountedAmount { get; set; }

    }
}
