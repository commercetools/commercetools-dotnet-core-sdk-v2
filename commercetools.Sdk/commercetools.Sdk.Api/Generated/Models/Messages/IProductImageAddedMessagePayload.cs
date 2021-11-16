using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ProductImageAddedMessagePayload))]
    public partial interface IProductImageAddedMessagePayload : IMessagePayload
    {
        long VariantId { get; set; }

        IImage Image { get; set; }

        bool Staged { get; set; }
    }
}
