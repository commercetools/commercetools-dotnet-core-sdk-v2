using System;

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class ExpressMultipleContainersFound : IExpressMultipleContainersFound
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }

        public Object Payload { get; set; }
        public ExpressMultipleContainersFound()
        {
            this.Code = "express_multiple_containers_found";
        }
    }
}
