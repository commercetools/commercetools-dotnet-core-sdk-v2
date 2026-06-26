using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.VariantKeySetMessage))]
    public partial interface IVariantKeySetMessage : IMessage
    {
        string Key { get; set; }

        string OldKey { get; set; }

    }
}
