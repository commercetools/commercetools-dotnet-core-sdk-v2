using commercetools.Api.Models.Common;
using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DiscriminatorValue("setName")]
    public partial class DiscountCodeSetNameAction : DiscountCodeUpdateAction
    {
        public LocalizedString Name { get; set;}
        public DiscountCodeSetNameAction()
        { 
           this.Action = "setName";
        }
    }
}
