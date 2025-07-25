using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.RecurrencePolicies;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrder))]
    public partial interface IRecurringOrder : IBaseResource
    {
        new string Id { get; set; }

        string Key { get; set; }

        new long Version { get; set; }

        ICartReference Cart { get; set; }

        IOrderReference OriginOrder { get; set; }

        DateTime StartsAt { get; set; }

        DateTime? ResumesAt { get; set; }

        DateTime? ExpiresAt { get; set; }

        DateTime? LastOrderAt { get; set; }

        DateTime? NextOrderAt { get; set; }

        ISkipConfiguration SkipConfiguration { get; set; }

        IStoreKeyReference Store { get; set; }

        IBusinessUnitKeyReference BusinessUnit { get; set; }

        IStateReference State { get; set; }

        IRecurringOrderState RecurringOrderState { get; set; }

        IRecurrencePolicySchedule Schedule { get; set; }

        ICustomerReference Customer { get; set; }

        string CustomerEmail { get; set; }

        ICustomFields Custom { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

    }
}
