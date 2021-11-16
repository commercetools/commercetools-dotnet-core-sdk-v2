namespace commercetools.ImportApi.Models.Errors
{
    public partial class InvalidJsonInput : IInvalidJsonInput
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        public InvalidJsonInput()
        { 
           this.Code = "InvalidJsonInput";
        }
    }
}
