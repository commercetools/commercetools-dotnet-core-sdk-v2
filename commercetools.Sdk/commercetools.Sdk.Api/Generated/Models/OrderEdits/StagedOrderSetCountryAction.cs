namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetCountryAction : IStagedOrderSetCountryAction
    {
        public string Action { get; set;}
        
        public string Country { get; set;}
        public StagedOrderSetCountryAction()
        { 
           this.Action = "setCountry";
        }
    }
}
