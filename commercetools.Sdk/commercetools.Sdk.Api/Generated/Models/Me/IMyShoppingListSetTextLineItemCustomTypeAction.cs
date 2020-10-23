using commercetools.Api.Models.Me;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyShoppingListSetTextLineItemCustomTypeAction))]
    public interface IMyShoppingListSetTextLineItemCustomTypeAction : IMyShoppingListUpdateAction
    {
        string TextLineItemId { get; set;}
        
        ITypeResourceIdentifier Type { get; set;}
        
        IFieldContainer Fields { get; set;}
    }
}
