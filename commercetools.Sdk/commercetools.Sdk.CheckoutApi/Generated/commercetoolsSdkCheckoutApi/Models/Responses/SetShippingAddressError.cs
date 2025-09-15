using System;

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class SetShippingAddressError : ISetShippingAddressError
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }

        public Object Payload { get; set; }
        public SetShippingAddressError()
        {
            this.Code = "set_shipping_address_error";
        }
    }
}
