using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    public partial class CustomFieldReferenceType : ICustomFieldReferenceType
    {
        public string Name { get; set;}
        
        public IReferenceTypeId ReferenceTypeId { get; set;}
        public CustomFieldReferenceType()
        { 
           this.Name = "Reference";
        }
    }
}
