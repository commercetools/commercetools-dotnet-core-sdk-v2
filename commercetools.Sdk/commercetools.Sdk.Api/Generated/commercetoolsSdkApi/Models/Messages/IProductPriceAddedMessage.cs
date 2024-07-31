using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceAddedMessage))]
    public partial interface IProductPriceAddedMessage : IMessage
    {
        long VariantId { get; set; }

        IPrice Price { get; set; }

        bool Staged { get; set; }

    }
}
