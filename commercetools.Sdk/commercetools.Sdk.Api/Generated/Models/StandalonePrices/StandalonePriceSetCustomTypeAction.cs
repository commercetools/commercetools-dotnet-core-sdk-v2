using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StandalonePriceSetCustomTypeAction : IStandalonePriceSetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public StandalonePriceSetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
