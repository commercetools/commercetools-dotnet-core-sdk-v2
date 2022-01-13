namespace commercetools.Api.Models.Errors
{
    public partial class QueryTimedOutError : IQueryTimedOutError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public QueryTimedOutError()
        {
            this.Code = "QueryTimedOut";
        }
    }
}
