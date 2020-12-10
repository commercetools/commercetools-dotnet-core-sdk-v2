using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.CustomFieldReferenceType))]
    public partial interface ICustomFieldReferenceType : IFieldType
    {
        IReferenceTypeId ReferenceTypeId { get; set;}
    }
}
