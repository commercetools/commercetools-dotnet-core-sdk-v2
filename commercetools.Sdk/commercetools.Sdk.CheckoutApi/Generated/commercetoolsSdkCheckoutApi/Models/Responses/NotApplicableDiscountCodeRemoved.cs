using System;

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class NotApplicableDiscountCodeRemoved : INotApplicableDiscountCodeRemoved
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }

        public Object Payload { get; set; }
        public NotApplicableDiscountCodeRemoved()
        {
            this.Code = "not_applicable_discount_code_removed";
        }
    }
}
