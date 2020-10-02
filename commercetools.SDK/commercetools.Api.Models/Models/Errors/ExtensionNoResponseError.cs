using commercetools.Api.Models.Common;
using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("ExtensionNoResponse")]
    public partial class ExtensionNoResponseError : ErrorObject
    {
        public LocalizedString LocalizedMessage { get; set;}
        
        public Object ExtensionExtraInfo { get; set;}
        
        public ErrorByExtension ErrorByExtension { get; set;}
        public ExtensionNoResponseError()
        { 
           this.Code = "ExtensionNoResponse";
        }
    }
}
