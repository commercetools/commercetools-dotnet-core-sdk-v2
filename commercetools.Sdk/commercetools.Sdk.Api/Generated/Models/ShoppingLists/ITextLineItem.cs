using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.TextLineItem))]
    public partial interface ITextLineItem 
    {
        DateTime AddedAt { get; set;}
        
        ICustomFields Custom { get; set;}
        
        ILocalizedString Description { get; set;}
        
        string Id { get; set;}
        
        ILocalizedString Name { get; set;}
        
        int Quantity { get; set;}
    }
}
