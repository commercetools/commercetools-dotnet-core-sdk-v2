using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    public  partial class CustomFieldsDraft : ICustomFieldsDraft
    {
        public ITypeResourceIdentifier Type { get; set;}
        
        public IFieldContainer Fields { get; set;}
    }
}
