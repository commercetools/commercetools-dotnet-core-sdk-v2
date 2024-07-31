

namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class OrderEditSetKeyAction : IOrderEditSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public OrderEditSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
