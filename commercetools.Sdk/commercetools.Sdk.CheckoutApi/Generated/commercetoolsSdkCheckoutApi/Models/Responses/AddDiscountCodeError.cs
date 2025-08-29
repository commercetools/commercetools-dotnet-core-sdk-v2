using System;

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class AddDiscountCodeError : IAddDiscountCodeError
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }

        public Object Payload { get; set; }
        public AddDiscountCodeError()
        {
            this.Code = "add_discount_code_error";
        }
    }
}
