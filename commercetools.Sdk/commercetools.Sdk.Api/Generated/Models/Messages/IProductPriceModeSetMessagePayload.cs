using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceModeSetMessagePayload))]
    public partial interface IProductPriceModeSetMessagePayload : IMessagePayload
    {
        IProductPriceModeEnum To { get; set; }

    }
}
