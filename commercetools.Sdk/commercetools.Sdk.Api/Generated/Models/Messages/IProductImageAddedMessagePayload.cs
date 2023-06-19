using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductImageAddedMessagePayload))]
    public partial interface IProductImageAddedMessagePayload : IMessagePayload
    {
        long VariantId { get; set; }

        IImage Image { get; set; }

        bool Staged { get; set; }

    }
}
