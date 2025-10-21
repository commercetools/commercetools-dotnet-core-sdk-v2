using System;

namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class RecurringOrderFailureError : IRecurringOrderFailureError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public Object Details { get; set; }
        public RecurringOrderFailureError()
        {
            this.Code = "RecurringOrderFailure";
        }
    }
}
