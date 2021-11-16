namespace commercetools.Api.Models.Errors
{
    public partial class PendingOperationError : IPendingOperationError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        public PendingOperationError()
        { 
           this.Code = "PendingOperation";
        }
    }
}
