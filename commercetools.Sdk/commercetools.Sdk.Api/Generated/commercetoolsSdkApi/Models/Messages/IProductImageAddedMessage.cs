using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductImageAddedMessage))]
    public partial interface IProductImageAddedMessage : IMessage
    {
        long VariantId { get; set; }

        IImage Image { get; set; }

        bool Staged { get; set; }

    }
}
