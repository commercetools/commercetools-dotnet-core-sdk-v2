using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeTargetAction))]
    public partial interface ICartDiscountChangeTargetAction : ICartDiscountUpdateAction
    {
        ICartDiscountTarget Target { get; set; }

    }
}
