using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetKeyAction))]
    public partial interface IProductDiscountSetKeyAction : IProductDiscountUpdateAction
    {
        string Key { get; set; }

    }
}
