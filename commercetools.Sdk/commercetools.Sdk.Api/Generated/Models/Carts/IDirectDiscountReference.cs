using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.DirectDiscountReference))]
    public partial interface IDirectDiscountReference : IReference
    {
        new string Id { get; set; }

    }
}
