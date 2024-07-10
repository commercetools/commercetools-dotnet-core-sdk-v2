using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeRequiresDiscountCodeAction))]
    public partial interface ICartDiscountChangeRequiresDiscountCodeAction : ICartDiscountUpdateAction
    {
        bool RequiresDiscountCode { get; set; }

    }
}
