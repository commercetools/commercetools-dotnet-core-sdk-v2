using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeIsActiveAction))]
    public partial interface ICartDiscountChangeIsActiveAction : ICartDiscountUpdateAction
    {
        bool IsActive { get; set; }

    }
}
