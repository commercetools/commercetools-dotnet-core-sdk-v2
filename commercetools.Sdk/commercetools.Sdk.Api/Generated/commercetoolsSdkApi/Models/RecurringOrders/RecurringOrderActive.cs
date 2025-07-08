using System;

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class RecurringOrderActive : IRecurringOrderActive
    {
        public string Type { get; set; }

        public DateTime? ResumesAt { get; set; }
        public RecurringOrderActive()
        {
            this.Type = "active";
        }
    }
}
