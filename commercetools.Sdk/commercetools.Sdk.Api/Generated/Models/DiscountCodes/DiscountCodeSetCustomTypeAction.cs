using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    public partial class DiscountCodeSetCustomTypeAction : IDiscountCodeSetCustomTypeAction
    {
        public string Action { get; set;}
        
        public ITypeResourceIdentifier Type { get; set;}
        
        public IFieldContainer Fields { get; set;}
        public DiscountCodeSetCustomTypeAction()
        { 
           this.Action = "setCustomType";
        }
    }
}
