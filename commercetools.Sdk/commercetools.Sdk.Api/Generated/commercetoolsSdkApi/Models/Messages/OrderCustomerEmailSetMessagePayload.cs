

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderCustomerEmailSetMessagePayload : IOrderCustomerEmailSetMessagePayload
    {
        public string Type { get; set; }

        public string Email { get; set; }

        public string OldEmail { get; set; }
        public OrderCustomerEmailSetMessagePayload()
        {
            this.Type = "OrderCustomerEmailSet";
        }
    }
}
