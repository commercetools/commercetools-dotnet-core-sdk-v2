using System.Collections.Generic;


namespace commercetools.Api.Models.Me
{
    public partial class MyShoppingListUpdate : IMyShoppingListUpdate
    {
        public long Version { get; set;}
        
        public List<IMyShoppingListUpdateAction> Actions { get; set;}
    }
}
