

namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitChangeStatusAction : IBusinessUnitChangeStatusAction
    {
        public string Action { get; set; }

        public string Status { get; set; }
        public BusinessUnitChangeStatusAction()
        {
            this.Action = "changeStatus";
        }
    }
}
