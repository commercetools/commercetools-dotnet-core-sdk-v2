using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductVariantAddedMessage))]
    public partial interface IProductVariantAddedMessage : IMessage
    {
        IProductVariant Variant { get; set; }

        bool Staged { get; set; }

    }
}
