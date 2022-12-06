using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceRemovedMessage))]
    public partial interface IProductPriceRemovedMessage : IMessage
    {
        long VariantId { get; set; }

        IPrice Price { get; set; }

        bool Staged { get; set; }

    }
}
