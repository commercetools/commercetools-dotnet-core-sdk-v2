using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.ExtensionNoResponseError))]
    public partial interface IExtensionNoResponseError : IErrorObject
    {
        string ExtensionId { get; set; }

        string ExtensionKey { get; set; }
    }
}
