using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DiscountGroupKeySetMessage))]
    public partial interface IDiscountGroupKeySetMessage : IMessage
    {
        string Key { get; set; }

        string OldKey { get; set; }

    }
}
