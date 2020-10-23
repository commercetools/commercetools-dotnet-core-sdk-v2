using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Errors
{
    public interface IReferenceExistsError : IErrorObject
    {
        string ReferencedBy { get; set;}
        
        ReferenceTypeId ReferencedByAsEnum { get; }
    }
}
