using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ExtensionBadResponseError))]
    public partial interface IExtensionBadResponseError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        ILocalizedString LocalizedMessage { get; set; }

        Object ExtensionExtraInfo { get; set; }

        IList<IExtensionError> ExtensionErrors { get; set; }
        IEnumerable<IExtensionError> ExtensionErrorsEnumerable { set => ExtensionErrors = value.ToList(); }


        string ExtensionBody { get; set; }

        int? ExtensionStatusCode { get; set; }

        string ExtensionId { get; set; }

        string ExtensionKey { get; set; }

    }
}
