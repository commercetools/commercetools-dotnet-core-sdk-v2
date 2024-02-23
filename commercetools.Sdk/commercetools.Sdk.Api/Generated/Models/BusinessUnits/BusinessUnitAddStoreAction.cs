using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitAddStoreAction : IBusinessUnitAddStoreAction
    {
        public string Action { get; set; }

        public IStoreResourceIdentifier Store { get; set; }
        public BusinessUnitAddStoreAction()
        {
            this.Action = "addStore";
        }
    }
}
