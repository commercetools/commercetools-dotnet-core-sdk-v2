using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ShoppingLists
{
    public class TextLineItem 
    {
        public DateTime AddedAt { get; set;}
        
        public CustomFields Custom { get; set;}
        
        public LocalizedString Description { get; set;}
        
        public string Id { get; set;}
        
        public LocalizedString Name { get; set;}
        
        public int Quantity { get; set;}
    }
}
