using System;

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class OrderCreated : IOrderCreated
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }

        public Object Payload { get; set; }
        public OrderCreated()
        {
            this.Code = "order_created";
        }
    }
}
