using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeIsActiveAction))]
    public partial interface IProductDiscountChangeIsActiveAction : IProductDiscountUpdateAction
    {
        bool IsActive { get; set; }

    }
}
