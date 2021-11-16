using commercetools.ImportApi.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    public partial class ResourceUpdateError : IResourceUpdateError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        
        public Object Resource { get; set;}
        public ResourceUpdateError()
        { 
           this.Code = "ResourceUpdate";
        }
    }
}
