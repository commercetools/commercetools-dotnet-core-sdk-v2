using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyShoppingListUpdate))]
    public partial interface IMyShoppingListUpdate 
    {
        long Version { get; set;}
        
        List<IMyShoppingListUpdateAction> Actions { get; set;}
    }
}
