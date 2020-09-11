using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ShoppingLists
{
    public class TextLineItemDraft 
    {
        public DateTime AddedAt { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        
        public LocalizedString Description { get; set;}
        
        public LocalizedString Name { get; set;}
        
        public int Quantity { get; set;}
    }
}
