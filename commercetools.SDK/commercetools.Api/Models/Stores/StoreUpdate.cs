using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Stores
{
    public partial class StoreUpdate 
    {
        public long Version { get; set;}
        
        public List<StoreUpdateAction> Actions { get; set;}
    }
}
