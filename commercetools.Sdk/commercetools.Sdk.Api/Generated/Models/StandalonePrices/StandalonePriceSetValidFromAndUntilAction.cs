using System;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StandalonePriceSetValidFromAndUntilAction : IStandalonePriceSetValidFromAndUntilAction
    {
        public string Action { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }
        public StandalonePriceSetValidFromAndUntilAction()
        {
            this.Action = "setValidFromAndUntil";
        }
    }
}
