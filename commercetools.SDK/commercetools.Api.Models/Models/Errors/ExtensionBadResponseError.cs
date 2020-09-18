using commercetools.Api.Models.Common;
using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("ExtensionBadResponse")]
    public class ExtensionBadResponseError : ErrorObject
    {
        public LocalizedString LocalizedMessage { get; set;}
        
        public Object ExtensionExtraInfo { get; set;}
        
        public ErrorByExtension ErrorByExtension { get; set;}
    }
}
