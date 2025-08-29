using System;

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class BadInputData : IBadInputData
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }

        public Object Payload { get; set; }
        public BadInputData()
        {
            this.Code = "invalid_fields";
        }
    }
}
