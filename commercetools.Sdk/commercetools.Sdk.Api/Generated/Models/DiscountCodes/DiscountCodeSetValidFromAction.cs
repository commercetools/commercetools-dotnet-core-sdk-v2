using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    public  partial class DiscountCodeSetValidFromAction : IDiscountCodeSetValidFromAction
    {
        public string Action { get; set;}
        
        public DateTime ValidFrom { get; set;}
        public DiscountCodeSetValidFromAction()
        { 
           this.Action = "setValidFrom";
        }
    }
}
