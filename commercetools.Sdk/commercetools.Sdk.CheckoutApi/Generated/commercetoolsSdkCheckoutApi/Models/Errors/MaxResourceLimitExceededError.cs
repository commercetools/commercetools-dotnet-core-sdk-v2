

namespace commercetools.Sdk.CheckoutApi.Models.Errors
{

    public partial class MaxResourceLimitExceededError : IMaxResourceLimitExceededError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public decimal Limit { get; set; }

        public string ResourceTypeId { get; set; }
        public MaxResourceLimitExceededError()
        {
            this.Code = "MaxResourceLimitExceeded";
        }
    }
}
