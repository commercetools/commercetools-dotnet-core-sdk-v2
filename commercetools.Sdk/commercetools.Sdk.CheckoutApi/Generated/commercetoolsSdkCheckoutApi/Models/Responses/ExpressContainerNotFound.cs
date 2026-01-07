using System;

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class ExpressContainerNotFound : IExpressContainerNotFound
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }

        public Object Payload { get; set; }
        public ExpressContainerNotFound()
        {
            this.Code = "express_container_not_found";
        }
    }
}
