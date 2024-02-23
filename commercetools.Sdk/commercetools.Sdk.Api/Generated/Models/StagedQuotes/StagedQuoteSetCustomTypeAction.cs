using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.StagedQuotes
{

    public partial class StagedQuoteSetCustomTypeAction : IStagedQuoteSetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public StagedQuoteSetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
