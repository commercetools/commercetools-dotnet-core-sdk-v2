using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DiscriminatorValue("changeIsActive")]
    public partial class DiscountCodeChangeIsActiveAction : DiscountCodeUpdateAction
    {
        public bool IsActive { get; set;}
        public DiscountCodeChangeIsActiveAction()
        { 
           this.Action = "changeIsActive";
        }
    }
}
