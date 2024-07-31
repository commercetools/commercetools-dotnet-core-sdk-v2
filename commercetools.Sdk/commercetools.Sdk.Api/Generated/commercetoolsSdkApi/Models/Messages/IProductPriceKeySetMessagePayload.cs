using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductPriceKeySetMessagePayload))]
    public partial interface IProductPriceKeySetMessagePayload : IMessagePayload
    {
        long VariantId { get; set; }

        string PriceId { get; set; }

        string OldKey { get; set; }

        string Key { get; set; }

        bool Staged { get; set; }

    }
}
