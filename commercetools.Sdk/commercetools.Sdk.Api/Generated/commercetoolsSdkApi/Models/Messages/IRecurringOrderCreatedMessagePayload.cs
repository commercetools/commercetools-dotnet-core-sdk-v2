using commercetools.Sdk.Api.Models.RecurringOrders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderCreatedMessagePayload))]
    public partial interface IRecurringOrderCreatedMessagePayload : IMessagePayload
    {
        IRecurringOrder RecurringOrder { get; set; }

    }
}
