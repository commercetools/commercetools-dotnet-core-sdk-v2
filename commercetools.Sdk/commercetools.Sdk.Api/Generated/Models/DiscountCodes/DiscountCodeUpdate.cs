using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    public  partial class DiscountCodeUpdate : IDiscountCodeUpdate
    {
        public long Version { get; set;}
        
        public List<IDiscountCodeUpdateAction> Actions { get; set;}
    }
}
