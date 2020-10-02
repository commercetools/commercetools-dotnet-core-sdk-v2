using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DiscriminatorValue("setCustomType")]
    public partial class DiscountCodeSetCustomTypeAction : DiscountCodeUpdateAction
    {
        public TypeResourceIdentifier Type { get; set;}
        
        public FieldContainer Fields { get; set;}
        public DiscountCodeSetCustomTypeAction()
        { 
           this.Action = "setCustomType";
        }
    }
}
