using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.AttributeReferenceType))]
    public partial interface IAttributeReferenceType : IAttributeType
    {
        IReferenceTypeId ReferenceTypeId { get; set;}
    }
}
