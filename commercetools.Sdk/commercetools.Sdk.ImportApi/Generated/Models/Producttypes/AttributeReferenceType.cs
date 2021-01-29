using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Producttypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Producttypes
{
    public partial class AttributeReferenceType : IAttributeReferenceType
    {
        public string Name { get; set;}
        
        public IReferenceType ReferenceTypeId { get; set;}
        public AttributeReferenceType()
        { 
           this.Name = "reference";
        }
    }
}
