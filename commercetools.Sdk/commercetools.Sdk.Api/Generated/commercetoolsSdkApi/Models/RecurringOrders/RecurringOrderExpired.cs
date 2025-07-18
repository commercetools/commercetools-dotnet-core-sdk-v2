

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class RecurringOrderExpired : IRecurringOrderExpired
    {
        public string Type { get; set; }
        public RecurringOrderExpired()
        {
            this.Type = "expired";
        }
    }
}
