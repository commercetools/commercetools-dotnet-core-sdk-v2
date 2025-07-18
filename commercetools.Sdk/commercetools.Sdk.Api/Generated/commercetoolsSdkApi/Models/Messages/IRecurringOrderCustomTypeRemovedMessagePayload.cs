using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderCustomTypeRemovedMessagePayload))]
    public partial interface IRecurringOrderCustomTypeRemovedMessagePayload : IMessagePayload
    {
        string PreviousTypeId { get; set; }

    }
}
