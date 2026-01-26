

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class NonRecurringOrdersOnly : INonRecurringOrdersOnly
    {
        public string Type { get; set; }
        public NonRecurringOrdersOnly()
        {
            this.Type = "NonRecurringOrdersOnly";
        }
    }
}
