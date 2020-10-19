using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.DiscountCodes
{
    public partial class DiscountCodeUpdate 
    {
        public long Version { get; set;}
        
        public List<DiscountCodeUpdateAction> Actions { get; set;}
    }
}
