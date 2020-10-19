using commercetools.Api.Models.Common;
using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("ExtensionBadResponse")]
    public partial class ExtensionBadResponseError : ErrorObject
    {
        public LocalizedString LocalizedMessage { get; set;}
        
        public Object ExtensionExtraInfo { get; set;}
        
        public ErrorByExtension ErrorByExtension { get; set;}
        public ExtensionBadResponseError()
        { 
           this.Code = "ExtensionBadResponse";
        }
    }
}
