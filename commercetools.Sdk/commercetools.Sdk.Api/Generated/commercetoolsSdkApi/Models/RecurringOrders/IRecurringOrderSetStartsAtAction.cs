using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetStartsAtAction))]
    public partial interface IRecurringOrderSetStartsAtAction : IRecurringOrderUpdateAction
    {
        DateTime StartsAt { get; set; }

    }
}
