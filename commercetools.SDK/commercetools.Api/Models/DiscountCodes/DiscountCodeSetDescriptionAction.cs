using commercetools.Api.Models.Common;
using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DiscriminatorValue("setDescription")]
    public partial class DiscountCodeSetDescriptionAction : DiscountCodeUpdateAction
    {
        public LocalizedString Description { get; set;}
        public DiscountCodeSetDescriptionAction()
        { 
           this.Action = "setDescription";
        }
    }
}
