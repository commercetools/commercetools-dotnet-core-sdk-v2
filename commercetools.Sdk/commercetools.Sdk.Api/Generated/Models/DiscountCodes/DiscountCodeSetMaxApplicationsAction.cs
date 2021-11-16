namespace commercetools.Api.Models.DiscountCodes
{
    public partial class DiscountCodeSetMaxApplicationsAction : IDiscountCodeSetMaxApplicationsAction
    {
        public string Action { get; set;}
        
        public long? MaxApplications { get; set;}
        public DiscountCodeSetMaxApplicationsAction()
        { 
           this.Action = "setMaxApplications";
        }
    }
}
