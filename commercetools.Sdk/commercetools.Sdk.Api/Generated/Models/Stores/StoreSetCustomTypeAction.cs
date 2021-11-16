using commercetools.Api.Models.Types;
using System;


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
