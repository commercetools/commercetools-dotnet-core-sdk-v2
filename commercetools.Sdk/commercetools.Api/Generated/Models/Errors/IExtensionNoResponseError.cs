using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Errors
{
    public interface IExtensionNoResponseError : IErrorObject
    {
        ILocalizedString LocalizedMessage { get; set;}
        
        Object ExtensionExtraInfo { get; set;}
        
        IErrorByExtension ErrorByExtension { get; set;}
    }
}
