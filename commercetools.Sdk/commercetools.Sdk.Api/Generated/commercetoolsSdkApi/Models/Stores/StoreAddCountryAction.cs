using commercetools.Sdk.Api.Models.StoreCountries;


namespace commercetools.Sdk.Api.Models.Stores
{

    public partial class StoreAddCountryAction : IStoreAddCountryAction
    {
        public string Action { get; set; }

        public IStoreCountry Country { get; set; }
        public StoreAddCountryAction()
        {
            this.Action = "addCountry";
        }
    }
}
