using System.Collections.Generic;


namespace commercetools.Api.Models.DiscountCodes
{
    public partial class DiscountCodeChangeGroupsAction : IDiscountCodeChangeGroupsAction
    {
        public string Action { get; set;}
        
        public List<string> Groups { get; set;}
        public DiscountCodeChangeGroupsAction()
        { 
           this.Action = "changeGroups";
        }
    }
}
