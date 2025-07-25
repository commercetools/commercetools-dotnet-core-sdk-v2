using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderSetCustomFieldAction))]
    public partial interface IRecurringOrderSetCustomFieldAction : IRecurringOrderUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
