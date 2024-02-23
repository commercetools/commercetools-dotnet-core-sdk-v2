using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountReference))]
    public partial interface IProductDiscountReference : IReference
    {
        IProductDiscount Obj { get; set; }

        new string Id { get; set; }

    }
}
