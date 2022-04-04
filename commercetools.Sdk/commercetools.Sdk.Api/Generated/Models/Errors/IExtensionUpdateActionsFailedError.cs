using commercetools.Sdk.Api.Models.Common;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ExtensionUpdateActionsFailedError))]
    public partial interface IExtensionUpdateActionsFailedError : IErrorObject
    {
        ILocalizedString LocalizedMessage { get; set; }

        Object ExtensionExtraInfo { get; set; }

        IErrorByExtension ErrorByExtension { get; set; }
    }
}
