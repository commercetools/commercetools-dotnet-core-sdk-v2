using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueRelativeDraft))]
    public partial interface IProductDiscountValueRelativeDraft : IProductDiscountValueDraft
    {
        long Permyriad { get; set; }

    }
}
