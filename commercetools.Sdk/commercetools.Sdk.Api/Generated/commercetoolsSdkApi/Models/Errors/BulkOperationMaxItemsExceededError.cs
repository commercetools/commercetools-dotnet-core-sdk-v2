namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class BulkOperationMaxItemsExceededError : IBulkOperationMaxItemsExceededError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public int Limit { get; set; }

        public int Provided { get; set; }
        public BulkOperationMaxItemsExceededError()
        {
            this.Code = "BulkOperationMaxItemsExceeded";
        }
    }
}
