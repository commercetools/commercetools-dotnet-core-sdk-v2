

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class AnyOrder : IAnyOrder
    {
        public string Type { get; set; }
        public AnyOrder()
        {
            this.Type = "AnyOrder";
        }
    }
}
