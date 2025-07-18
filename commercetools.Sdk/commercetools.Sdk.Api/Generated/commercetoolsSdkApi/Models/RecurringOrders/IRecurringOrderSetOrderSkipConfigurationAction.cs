using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetOrderSkipConfigurationAction))]
    public partial interface IRecurringOrderSetOrderSkipConfigurationAction : IRecurringOrderUpdateAction
    {
        ISkipConfigurationDraft SkipConfiguration { get; set; }

        DateTime? UpdatedExpiresAt { get; set; }

    }
}
