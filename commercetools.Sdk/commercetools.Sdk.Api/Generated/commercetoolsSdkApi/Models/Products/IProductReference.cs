using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductReference))]
    public partial interface IProductReference : IReference
    {
        IProduct Obj { get; set; }

        new string Id { get; set; }

    }
}
