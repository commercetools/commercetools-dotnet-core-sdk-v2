using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DiscriminatorValue("setValidUntil")]
    public partial class DiscountCodeSetValidUntilAction : DiscountCodeUpdateAction
    {
        public DateTime ValidUntil { get; set;}
        public DiscountCodeSetValidUntilAction()
        { 
           this.Action = "setValidUntil";
        }
    }
}
