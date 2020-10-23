using commercetools.Api.Models.Inventories;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    public  partial class InventoryEntrySetCustomTypeAction : IInventoryEntrySetCustomTypeAction
    {
        public string Action { get; set;}
        
        public ITypeResourceIdentifier Type { get; set;}
        
        public IFieldContainer Fields { get; set;}
        public InventoryEntrySetCustomTypeAction()
        { 
           this.Action = "setCustomType";
        }
    }
}
