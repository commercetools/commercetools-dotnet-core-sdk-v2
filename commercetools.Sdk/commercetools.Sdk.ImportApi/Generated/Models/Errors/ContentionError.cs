namespace commercetools.ImportApi.Models.Errors
{
    public partial class ContentionError : IContentionError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        public ContentionError()
        { 
           this.Code = "Contention";
        }
    }
}
