using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeStackingModeAction))]
    public partial interface ICartDiscountChangeStackingModeAction : ICartDiscountUpdateAction
    {
        IStackingMode StackingMode { get; set; }

    }
}
