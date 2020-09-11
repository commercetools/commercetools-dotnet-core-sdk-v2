using commercetools.Api.Models.Common;
using commercetools.Api.Models.Stores;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Common
{
    [JsonConverter(typeof(JsonSubtypes), "typeId")]
    [JsonSubtypes.KnownSubType(typeof(StoreKeyReference), "store")]
    public abstract class KeyReference 
    {
        public ReferenceTypeId TypeId { get; set;}
        
        public string Key { get; set;}
    }
}
