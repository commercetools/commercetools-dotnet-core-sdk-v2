using System;

namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCartSetLineItemCustomFieldAction : IMyCartSetLineItemCustomFieldAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public MyCartSetLineItemCustomFieldAction()
        {
            this.Action = "setLineItemCustomField";
        }
    }
}
