using commercetools.Sdk.Api.Models.StoreCountries;


namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreRemoveCountryAction : IStoreRemoveCountryAction
    {
        public string Action { get; set; }

        public IStoreCountry Country { get; set; }
        public StoreRemoveCountryAction()
        {
            this.Action = "removeCountry";
        }
    }
}
