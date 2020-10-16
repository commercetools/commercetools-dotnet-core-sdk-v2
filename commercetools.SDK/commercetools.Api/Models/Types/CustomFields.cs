using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Types
{
    public partial class CustomFields 
    {
        public TypeReference Type { get; set;}
        
        public FieldContainer Fields { get; set;}
    }
}
