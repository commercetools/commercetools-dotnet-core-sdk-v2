using commercetools.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductVariantAddedMessage))]
    public partial interface IProductVariantAddedMessage : IMessage
    {
        IProductVariant Variant { get; set; }

        bool Staged { get; set; }
    }
}
