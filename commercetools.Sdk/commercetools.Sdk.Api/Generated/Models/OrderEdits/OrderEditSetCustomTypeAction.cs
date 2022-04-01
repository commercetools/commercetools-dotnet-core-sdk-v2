using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    public partial class OrderEditSetCustomTypeAction : IOrderEditSetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public OrderEditSetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
