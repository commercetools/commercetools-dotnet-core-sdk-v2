using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DiscriminatorValue("changeGroups")]
    public partial class DiscountCodeChangeGroupsAction : DiscountCodeUpdateAction
    {
        public List<string> Groups { get; set;}
        public DiscountCodeChangeGroupsAction()
        { 
           this.Action = "changeGroups";
        }
    }
}
