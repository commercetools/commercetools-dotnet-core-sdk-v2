using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderActive))]
    public partial interface IRecurringOrderActive : IRecurringOrderStateDraft
    {
        DateTime? ResumesAt { get; set; }

    }
}
