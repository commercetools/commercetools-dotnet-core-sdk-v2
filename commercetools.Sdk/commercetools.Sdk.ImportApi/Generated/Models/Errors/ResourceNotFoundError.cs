using System;


namespace commercetools.ImportApi.Models.Errors
{
    public partial class ResourceNotFoundError : IResourceNotFoundError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        
        public Object Resource { get; set;}
        public ResourceNotFoundError()
        { 
           this.Code = "ResourceNotFound";
        }
    }
}
