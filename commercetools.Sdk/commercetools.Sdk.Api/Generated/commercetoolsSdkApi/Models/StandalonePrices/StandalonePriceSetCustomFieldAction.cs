using System;

namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StandalonePriceSetCustomFieldAction : IStandalonePriceSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public StandalonePriceSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
