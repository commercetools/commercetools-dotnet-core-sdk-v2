using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringReference))]
    public partial interface IProductTailoringReference : IReference
    {
        new string Id { get; set; }

        IProductTailoring Obj { get; set; }

    }
}
