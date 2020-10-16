using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DiscriminatorValue("setCustomField")]
    public partial class DiscountCodeSetCustomFieldAction : DiscountCodeUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public DiscountCodeSetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}
