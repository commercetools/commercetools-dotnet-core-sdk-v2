using commercetools.Api.Models.Stores;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    public partial class StoreSetCustomTypeAction : IStoreSetCustomTypeAction
    {
        public string Action { get; set;}
        
        public ITypeResourceIdentifier Type { get; set;}
        
        public Object Fields { get; set;}
        public StoreSetCustomTypeAction()
        { 
           this.Action = "setCustomType";
        }
    }
}
