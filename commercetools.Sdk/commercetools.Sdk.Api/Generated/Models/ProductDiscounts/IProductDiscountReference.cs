using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountReference))]
    public partial interface IProductDiscountReference : IReference
    {
        IProductDiscount Obj { get; set; }

        new string Id { get; set; }
    }
}
