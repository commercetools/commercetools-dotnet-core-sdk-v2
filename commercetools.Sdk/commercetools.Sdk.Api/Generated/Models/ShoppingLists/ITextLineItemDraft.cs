using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.TextLineItemDraft))]
    public partial interface ITextLineItemDraft 
    {
        DateTime? AddedAt { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
        
        ILocalizedString Description { get; set;}
        
        ILocalizedString Name { get; set;}
        
        int? Quantity { get; set;}
    }
}
