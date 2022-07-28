using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeIsActiveAction))]
    public partial interface IProductDiscountChangeIsActiveAction : IProductDiscountUpdateAction
    {
        bool IsActive { get; set; }

    }
}
