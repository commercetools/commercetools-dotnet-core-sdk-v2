using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomTypeRemovedMessage))]
    public partial interface IRecurringOrderCustomTypeRemovedMessage : IMessage
    {
        string PreviousTypeId { get; set; }

    }
}
