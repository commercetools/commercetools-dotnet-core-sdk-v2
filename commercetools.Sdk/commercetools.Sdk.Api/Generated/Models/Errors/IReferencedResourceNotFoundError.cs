using commercetools.Api.Models.Common;
using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.ReferencedResourceNotFoundError))]
    public partial interface IReferencedResourceNotFoundError : IErrorObject
    {
        IReferenceTypeId TypeId { get; set; }

        string Id { get; set; }

        string Key { get; set; }
    }
}
