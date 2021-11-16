using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountChangeValueAction))]
    public partial interface IProductDiscountChangeValueAction : IProductDiscountUpdateAction
    {
        IProductDiscountValueDraft Value { get; set; }
    }
}
