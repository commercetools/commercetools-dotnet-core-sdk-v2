using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Types
{
    public class CustomFields 
    {
        public TypeReference Type { get; set;}
        
        public FieldContainer Fields { get; set;}
    }
}
