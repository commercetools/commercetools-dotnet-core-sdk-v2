using commercetools.Sdk.Api.Models.RecurringOrders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderStateChangedMessage))]
    public partial interface IRecurringOrderStateChangedMessage : IMessage
    {
        IRecurringOrderState State { get; set; }

        IRecurringOrderState OldState { get; set; }

    }
}
