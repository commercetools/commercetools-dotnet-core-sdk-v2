using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeNameAction))]
    public partial interface IProductDiscountChangeNameAction : IProductDiscountUpdateAction
    {
        ILocalizedString Name { get; set; }

    }
}
