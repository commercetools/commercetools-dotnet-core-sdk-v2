using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.DiscountedLineItemPortionDraft))]
    public partial interface IDiscountedLineItemPortionDraft
    {
        IReference Discount { get; set; }

        ITypedMoneyDraft DiscountedAmount { get; set; }

    }
}
