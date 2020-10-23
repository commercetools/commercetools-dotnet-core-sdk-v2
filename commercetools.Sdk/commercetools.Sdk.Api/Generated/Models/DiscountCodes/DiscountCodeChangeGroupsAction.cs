using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    public  partial class DiscountCodeChangeGroupsAction : IDiscountCodeChangeGroupsAction
    {
        public string Action { get; set;}
        
        public List<string> Groups { get; set;}
        public DiscountCodeChangeGroupsAction()
        { 
           this.Action = "changeGroups";
        }
    }
}
