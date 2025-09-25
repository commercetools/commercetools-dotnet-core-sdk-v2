using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.Types;
using System;

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class RecurringOrderDraft : IRecurringOrderDraft
    {
        public string Key { get; set; }

        public ICartResourceIdentifier Cart { get; set; }

        public long CartVersion { get; set; }

        public DateTime? StartsAt { get; set; }

        public DateTime? ExpiresAt { get; set; }

        public IStateResourceIdentifier State { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
