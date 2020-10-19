using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DiscriminatorValue("setValidFrom")]
    public partial class DiscountCodeSetValidFromAction : DiscountCodeUpdateAction
    {
        public DateTime ValidFrom { get; set;}
        public DiscountCodeSetValidFromAction()
        { 
           this.Action = "setValidFrom";
        }
    }
}
