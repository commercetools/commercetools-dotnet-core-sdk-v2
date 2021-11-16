namespace commercetools.Api.Models.Errors
{
    public partial class QueryComplexityLimitExceededError : IQueryComplexityLimitExceededError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        public QueryComplexityLimitExceededError()
        { 
           this.Code = "QueryComplexityLimitExceeded";
        }
    }
}
