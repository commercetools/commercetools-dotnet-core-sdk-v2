using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomFieldRemovedMessage))]
    public partial interface IRecurringOrderCustomFieldRemovedMessage : IMessage
    {
        string Name { get; set; }

    }
}
