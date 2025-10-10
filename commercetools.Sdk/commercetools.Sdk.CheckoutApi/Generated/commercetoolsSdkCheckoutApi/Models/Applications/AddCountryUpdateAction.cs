

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class AddCountryUpdateAction : IAddCountryUpdateAction
    {
        public string Action { get; set; }

        public string Country { get; set; }
        public AddCountryUpdateAction()
        {
            this.Action = "addCountry";
        }
    }
}
