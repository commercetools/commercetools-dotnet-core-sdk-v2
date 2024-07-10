using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeValueAction))]
    public partial interface ICartDiscountChangeValueAction : ICartDiscountUpdateAction
    {
        ICartDiscountValueDraft Value { get; set; }

    }
}
