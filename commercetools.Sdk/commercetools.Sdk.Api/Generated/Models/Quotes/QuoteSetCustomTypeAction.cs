using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Quotes
{
    public partial class QuoteSetCustomTypeAction : IQuoteSetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public QuoteSetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
