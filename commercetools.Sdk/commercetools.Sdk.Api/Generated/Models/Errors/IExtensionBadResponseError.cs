using commercetools.Api.Models.Common;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.ExtensionBadResponseError))]
    public partial interface IExtensionBadResponseError : IErrorObject
    {
        ILocalizedString LocalizedMessage { get; set;}
        
        Object ExtensionExtraInfo { get; set;}
        
        IErrorByExtension ErrorByExtension { get; set;}
    }
}
