using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Errors
{
    public partial class MaxResourceLimitExceededError : IMaxResourceLimitExceededError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        
        public IReferenceTypeId ExceededResource { get; set;}
        public MaxResourceLimitExceededError()
        { 
           this.Code = "MaxResourceLimitExceeded";
        }
    }
}
