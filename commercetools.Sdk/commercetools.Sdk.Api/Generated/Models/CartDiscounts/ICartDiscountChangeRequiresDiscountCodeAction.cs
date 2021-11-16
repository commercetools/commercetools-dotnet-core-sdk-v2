using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountChangeRequiresDiscountCodeAction))]
    public partial interface ICartDiscountChangeRequiresDiscountCodeAction : ICartDiscountUpdateAction
    {
        bool RequiresDiscountCode { get; set;}
    }
}
