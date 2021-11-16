namespace commercetools.ImportApi.Models.Errors
{
    public partial class GenericError : IGenericError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        public GenericError()
        { 
           this.Code = "Generic";
        }
    }
}
