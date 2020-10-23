using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ProductTypes
{
    public interface IAttributeReferenceType : IAttributeType
    {
        string ReferenceTypeId { get; set;}
        
        ReferenceTypeId ReferenceTypeIdAsEnum { get; }
    }
}
