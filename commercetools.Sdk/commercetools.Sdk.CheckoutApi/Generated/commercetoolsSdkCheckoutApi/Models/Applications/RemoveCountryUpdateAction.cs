

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class RemoveCountryUpdateAction : IRemoveCountryUpdateAction
    {
        public string Action { get; set; }

        public string Country { get; set; }
        public RemoveCountryUpdateAction()
        {
            this.Action = "removeCountry";
        }
    }
}
