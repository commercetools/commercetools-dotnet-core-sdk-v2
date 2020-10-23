using commercetools.Api.Models.Common;
using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    public  partial class DiscountCodeSetDescriptionAction : IDiscountCodeSetDescriptionAction
    {
        public string Action { get; set;}
        
        public ILocalizedString Description { get; set;}
        public DiscountCodeSetDescriptionAction()
        { 
           this.Action = "setDescription";
        }
    }
}
