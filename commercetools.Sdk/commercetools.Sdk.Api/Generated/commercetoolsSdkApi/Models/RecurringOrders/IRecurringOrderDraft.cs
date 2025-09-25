using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderDraft))]
    public partial interface IRecurringOrderDraft
    {
        string Key { get; set; }

        ICartResourceIdentifier Cart { get; set; }

        long CartVersion { get; set; }

        DateTime? StartsAt { get; set; }

        DateTime? ExpiresAt { get; set; }

        IStateResourceIdentifier State { get; set; }

        ICustomFieldsDraft Custom { get; set; }

    }
}
