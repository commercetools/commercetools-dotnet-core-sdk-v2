using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyShoppingListSetCustomFieldAction))]
    public partial interface IMyShoppingListSetCustomFieldAction : IMyShoppingListUpdateAction
    {
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
