using commercetools.Sdk.Api.Models.RecurrencePolicies;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.RecurringOrderScheduleSetMessagePayload))]
    public partial interface IRecurringOrderScheduleSetMessagePayload : IMessagePayload
    {
        IRecurrencePolicySchedule RecurrencePolicySchedule { get; set; }

        IRecurrencePolicySchedule OldRecurrencePolicySchedule { get; set; }

    }
}
