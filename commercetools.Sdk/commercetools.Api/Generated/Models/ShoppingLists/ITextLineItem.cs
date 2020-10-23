using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ShoppingLists
{
    public interface ITextLineItem 
    {
        DateTime AddedAt { get; set;}
        
        ICustomFields Custom { get; set;}
        
        ILocalizedString Description { get; set;}
        
        string Id { get; set;}
        
        ILocalizedString Name { get; set;}
        
        int Quantity { get; set;}
    }
}
