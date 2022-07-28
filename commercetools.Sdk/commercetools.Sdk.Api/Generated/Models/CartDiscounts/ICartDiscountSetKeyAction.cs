using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetKeyAction))]
    public partial interface ICartDiscountSetKeyAction : ICartDiscountUpdateAction
    {
        string Key { get; set; }

    }
}
