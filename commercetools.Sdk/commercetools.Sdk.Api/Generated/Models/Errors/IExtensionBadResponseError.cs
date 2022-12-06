using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ExtensionBadResponseError))]
    public partial interface IExtensionBadResponseError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        ILocalizedString LocalizedMessage { get; set; }

        Object ExtensionExtraInfo { get; set; }

        List<IExtensionError> ExtensionErrors { get; set; }

        string ExtensionBody { get; set; }

        int? ExtensionStatusCode { get; set; }

        string ExtensionId { get; set; }

        string ExtensionKey { get; set; }

    }
}
