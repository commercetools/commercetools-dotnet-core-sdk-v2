using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.VariantSkuSetMessage))]
    public partial interface IVariantSkuSetMessage : IMessage
    {
        string Sku { get; set; }

        string OldSku { get; set; }

        bool Staged { get; set; }

    }
}
