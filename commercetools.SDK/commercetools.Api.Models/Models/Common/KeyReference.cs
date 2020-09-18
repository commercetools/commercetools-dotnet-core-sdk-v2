using commercetools.Api.Models.Common;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [Discriminator(nameof(TypeId))]
    public abstract class KeyReference 
    {
        public string TypeId { get; set;}
        
        public ReferenceTypeId TypeIdAsEnum => this.TypeId.GetEnum<ReferenceTypeId>();
        
        public string Key { get; set;}
    }
}
