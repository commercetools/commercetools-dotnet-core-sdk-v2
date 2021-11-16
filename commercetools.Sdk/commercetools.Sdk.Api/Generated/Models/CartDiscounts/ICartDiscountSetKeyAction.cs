using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountSetKeyAction))]
    public partial interface ICartDiscountSetKeyAction : ICartDiscountUpdateAction
    {
        string Key { get; set; }
    }
}
