

namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class AnyOrderDraft : IAnyOrderDraft
    {
        public string Type { get; set; }
        public AnyOrderDraft()
        {
            this.Type = "AnyOrder";
        }
    }
}
