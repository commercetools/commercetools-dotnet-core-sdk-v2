using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    public partial class StagedOrderSetCustomLineItemCustomTypeAction : IStagedOrderSetCustomLineItemCustomTypeAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public StagedOrderSetCustomLineItemCustomTypeAction()
        {
            this.Action = "setCustomLineItemCustomType";
        }
    }
}
