using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomFieldRemovedMessagePayload))]
    public partial interface IRecurringOrderCustomFieldRemovedMessagePayload : IMessagePayload
    {
        string Name { get; set; }

    }
}
