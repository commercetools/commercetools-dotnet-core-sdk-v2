using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    public class TypeUpdate 
    {
        public long Version { get; set;}
        
        public List<TypeUpdateAction> Actions { get; set;}
    }
}
