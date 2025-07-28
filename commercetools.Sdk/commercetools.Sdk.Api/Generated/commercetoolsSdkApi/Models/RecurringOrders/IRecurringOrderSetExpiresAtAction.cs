using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetExpiresAtAction))]
    public partial interface IRecurringOrderSetExpiresAtAction : IRecurringOrderUpdateAction
    {
        DateTime? ExpiresAt { get; set; }

    }
}
