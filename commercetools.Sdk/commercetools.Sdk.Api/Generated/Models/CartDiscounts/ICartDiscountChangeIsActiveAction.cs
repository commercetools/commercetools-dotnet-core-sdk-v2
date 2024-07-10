using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeIsActiveAction))]
    public partial interface ICartDiscountChangeIsActiveAction : ICartDiscountUpdateAction
    {
        bool IsActive { get; set; }

    }
}
