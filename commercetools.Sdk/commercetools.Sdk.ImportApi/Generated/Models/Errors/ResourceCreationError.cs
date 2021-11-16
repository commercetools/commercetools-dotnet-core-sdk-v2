using System;


namespace commercetools.ImportApi.Models.Errors
{
    public partial class ResourceCreationError : IResourceCreationError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        
        public Object Resource { get; set;}
        public ResourceCreationError()
        { 
           this.Code = "ResourceCreation";
        }
    }
}
