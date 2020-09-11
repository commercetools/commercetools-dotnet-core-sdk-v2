using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Stores
{
    public class StoreUpdate 
    {
        public long Version { get; set;}
        
        public List<StoreUpdateAction> Actions { get; set;}
    }
}
