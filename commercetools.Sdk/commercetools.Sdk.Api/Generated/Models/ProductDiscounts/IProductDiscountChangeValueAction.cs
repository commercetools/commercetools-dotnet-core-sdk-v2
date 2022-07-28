using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeValueAction))]
    public partial interface IProductDiscountChangeValueAction : IProductDiscountUpdateAction
    {
        IProductDiscountValueDraft Value { get; set; }

    }
}
