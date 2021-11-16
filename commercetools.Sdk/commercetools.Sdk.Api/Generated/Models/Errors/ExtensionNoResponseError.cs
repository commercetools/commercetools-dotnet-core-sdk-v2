namespace commercetools.Api.Models.Errors
{
    public partial class ExtensionNoResponseError : IExtensionNoResponseError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        
        public string ExtensionId { get; set;}
        
        public string ExtensionKey { get; set;}
        public ExtensionNoResponseError()
        { 
           this.Code = "ExtensionNoResponse";
        }
    }
}
