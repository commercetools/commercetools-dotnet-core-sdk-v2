

namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitSetContactEmailAction : IMyBusinessUnitSetContactEmailAction
    {
        public string Action { get; set; }

        public string ContactEmail { get; set; }
        public MyBusinessUnitSetContactEmailAction()
        {
            this.Action = "setContactEmail";
        }
    }
}
