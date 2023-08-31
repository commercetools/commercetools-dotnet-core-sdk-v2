using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLExtensionUpdateActionsFailedError))]
    public partial interface IGraphQLExtensionUpdateActionsFailedError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        ILocalizedString LocalizedMessage { get; set; }

        Object ExtensionExtraInfo { get; set; }

        IList<IExtensionError> ExtensionErrors { get; set; }
        IEnumerable<IExtensionError> ExtensionErrorsEnumerable { set => ExtensionErrors = value.ToList(); }


    }
}