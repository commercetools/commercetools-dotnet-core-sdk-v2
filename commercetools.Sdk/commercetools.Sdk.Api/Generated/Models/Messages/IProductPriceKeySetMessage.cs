using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceKeySetMessage))]
    public partial interface IProductPriceKeySetMessage : IMessage
    {
        long VariantId { get; set; }

        string PriceId { get; set; }

        string OldKey { get; set; }

        string Key { get; set; }

        bool Staged { get; set; }

    }
}
