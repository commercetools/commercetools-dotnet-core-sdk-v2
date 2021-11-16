using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountChangeIsActiveAction))]
    public partial interface ICartDiscountChangeIsActiveAction : ICartDiscountUpdateAction
    {
        bool IsActive { get; set;}
    }
}
