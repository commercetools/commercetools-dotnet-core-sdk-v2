using System;

namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StandalonePriceSetValidFromAction : IStandalonePriceSetValidFromAction
    {
        public string Action { get; set; }

        public DateTime? ValidFrom { get; set; }
        public StandalonePriceSetValidFromAction()
        {
            this.Action = "setValidFrom";
        }
    }
}
