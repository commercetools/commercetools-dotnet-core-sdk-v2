using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyShoppingListAddTextLineItemAction))]
    public interface IMyShoppingListAddTextLineItemAction : IMyShoppingListUpdateAction
    {
        ILocalizedString Name { get; set;}
        
        ILocalizedString Description { get; set;}
        
        long? Quantity { get; set;}
        
        DateTime AddedAt { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
    }
}
