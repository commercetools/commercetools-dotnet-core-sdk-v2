namespace commercetools.Api.Models.Errors
{
    public partial class InvalidCurrentPasswordError : IInvalidCurrentPasswordError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        public InvalidCurrentPasswordError()
        { 
           this.Code = "InvalidCurrentPassword";
        }
    }
}
