namespace commercetools.ImportApi.Models.Errors
{
    public partial class InvalidOperation : IInvalidOperation
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        public InvalidOperation()
        { 
           this.Code = "InvalidOperation";
        }
    }
}
