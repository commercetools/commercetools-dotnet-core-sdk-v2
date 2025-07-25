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

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class RecurringOrder : IRecurringOrder
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public string Key { get; set; }

        public ICartReference Cart { get; set; }

        public IOrderReference OriginOrder { get; set; }

        public DateTime StartsAt { get; set; }

        public DateTime? ResumesAt { get; set; }

        public DateTime? ExpiresAt { get; set; }

        public DateTime? LastOrderAt { get; set; }

        public DateTime? NextOrderAt { get; set; }

        public ISkipConfiguration SkipConfiguration { get; set; }

        public IStoreKeyReference Store { get; set; }

        public IBusinessUnitKeyReference BusinessUnit { get; set; }

        public IStateReference State { get; set; }

        public IRecurringOrderState RecurringOrderState { get; set; }

        public IRecurrencePolicySchedule Schedule { get; set; }

        public ICustomerReference Customer { get; set; }

        public string CustomerEmail { get; set; }

        public ICustomFields Custom { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }
    }
}
