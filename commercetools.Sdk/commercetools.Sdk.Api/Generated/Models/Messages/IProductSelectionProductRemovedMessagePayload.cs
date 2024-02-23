using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductSelectionProductRemovedMessagePayload))]
    public partial interface IProductSelectionProductRemovedMessagePayload : IMessagePayload
    {
        IProductReference Product { get; set; }

    }
}
