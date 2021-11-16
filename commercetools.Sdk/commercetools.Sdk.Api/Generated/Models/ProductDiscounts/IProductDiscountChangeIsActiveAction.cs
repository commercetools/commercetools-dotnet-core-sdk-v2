using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountChangeIsActiveAction))]
    public partial interface IProductDiscountChangeIsActiveAction : IProductDiscountUpdateAction
    {
        bool IsActive { get; set;}
    }
}
