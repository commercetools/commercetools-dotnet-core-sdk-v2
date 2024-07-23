using System;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StandalonePriceSetValidUntilAction : IStandalonePriceSetValidUntilAction
    {
        public string Action { get; set; }

        public DateTime? ValidUntil { get; set; }
        public StandalonePriceSetValidUntilAction()
        {
            this.Action = "setValidUntil";
        }
    }
}
