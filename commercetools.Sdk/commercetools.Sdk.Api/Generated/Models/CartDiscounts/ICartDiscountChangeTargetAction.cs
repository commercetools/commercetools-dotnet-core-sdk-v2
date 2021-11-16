using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountChangeTargetAction))]
    public partial interface ICartDiscountChangeTargetAction : ICartDiscountUpdateAction
    {
        ICartDiscountTarget Target { get; set;}
    }
}
