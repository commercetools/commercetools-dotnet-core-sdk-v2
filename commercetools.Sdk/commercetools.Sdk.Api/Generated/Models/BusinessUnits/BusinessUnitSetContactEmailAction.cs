namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitSetContactEmailAction : IBusinessUnitSetContactEmailAction
    {
        public string Action { get; set; }

        public string ContactEmail { get; set; }
        public BusinessUnitSetContactEmailAction()
        {
            this.Action = "setContactEmail";
        }
    }
}
