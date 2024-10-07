using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeReference))]
    public partial interface IProductTypeReference : IReference
    {
        IProductType Obj { get; set; }

        new string Id { get; set; }

    }
}
