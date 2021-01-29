using commercetools.ImportApi.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.ResourceCreationError))]
    public partial interface IResourceCreationError : IErrorObject
    {
        Object Resource { get; set;}
    }
}
