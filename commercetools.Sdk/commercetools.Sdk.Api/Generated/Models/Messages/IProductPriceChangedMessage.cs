using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceChangedMessage))]
    public partial interface IProductPriceChangedMessage : IMessage
    {
        long VariantId { get; set; }

        IPrice OldPrice { get; set; }

        IPrice NewPrice { get; set; }

        bool Staged { get; set; }

        IPrice OldStagedPrice { get; set; }

    }
}
