using commercetools.Api.Models.Common;
using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public partial class ExtensionNoResponseError : IExtensionNoResponseError
    {
        public string Code { get; set;}
        
        public string Message { get; set;}
        
        public ILocalizedString LocalizedMessage { get; set;}
        
        public Object ExtensionExtraInfo { get; set;}
        
        public IErrorByExtension ErrorByExtension { get; set;}
        public ExtensionNoResponseError()
        { 
           this.Code = "ExtensionNoResponse";
        }
    }
}
