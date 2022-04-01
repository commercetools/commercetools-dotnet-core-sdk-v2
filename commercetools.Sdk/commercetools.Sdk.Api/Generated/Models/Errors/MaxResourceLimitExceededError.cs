using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Errors
{
    public partial class MaxResourceLimitExceededError : IMaxResourceLimitExceededError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IReferenceTypeId ExceededResource { get; set; }
        public MaxResourceLimitExceededError()
        {
            this.Code = "MaxResourceLimitExceeded";
        }
    }
}
