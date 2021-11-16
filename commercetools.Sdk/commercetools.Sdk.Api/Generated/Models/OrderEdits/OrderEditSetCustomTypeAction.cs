using commercetools.Api.Models.Types;
using System;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class OrderEditSetCustomTypeAction : IOrderEditSetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public Object Fields { get; set; }
        public OrderEditSetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
