using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyShoppingListSetTextLineItemCustomFieldAction))]
    public partial interface IMyShoppingListSetTextLineItemCustomFieldAction : IMyShoppingListUpdateAction
    {
        string TextLineItemId { get; set; }

        string Name { get; set; }

        Object Value { get; set; }
    }
}
