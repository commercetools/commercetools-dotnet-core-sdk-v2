using commercetools.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductVariantAddedMessagePayload))]
    public partial interface IProductVariantAddedMessagePayload : IMessagePayload
    {
        IProductVariant Variant { get; set;}
        
        bool Staged { get; set;}
    }
}
