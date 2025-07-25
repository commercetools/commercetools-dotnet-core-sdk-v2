using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.RecurringOrders
{

    public partial class RecurringOrderSetCustomTypeAction : IRecurringOrderSetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public RecurringOrderSetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
