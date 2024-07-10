using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountReference))]
    public partial interface ICartDiscountReference : IReference
    {
        ICartDiscount Obj { get; set; }

        new string Id { get; set; }

    }
}
