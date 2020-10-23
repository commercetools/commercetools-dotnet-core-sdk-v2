using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    public  partial class CustomFieldSetType : ICustomFieldSetType
    {
        public string Name { get; set;}
        
        public IFieldType ElementType { get; set;}
        public CustomFieldSetType()
        { 
           this.Name = "Set";
        }
    }
}
