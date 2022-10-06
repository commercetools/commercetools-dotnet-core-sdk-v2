using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitRemoveStoreAction : IBusinessUnitRemoveStoreAction
    {
        public string Action { get; set; }

        public IStoreResourceIdentifier Store { get; set; }
        public BusinessUnitRemoveStoreAction()
        {
            this.Action = "removeStore";
        }
    }
}
