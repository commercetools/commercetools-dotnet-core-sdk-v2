using commercetools.Sdk.Api.Models.RecurringOrders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderCreatedMessage))]
    public partial interface IRecurringOrderCreatedMessage : IMessage
    {
        IRecurringOrder Order { get; set; }

    }
}
