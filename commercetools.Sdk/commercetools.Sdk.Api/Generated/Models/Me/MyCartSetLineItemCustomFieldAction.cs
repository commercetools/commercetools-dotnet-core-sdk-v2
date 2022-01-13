using System;


namespace commercetools.Api.Models.Me
{
    public partial class MyCartSetLineItemCustomFieldAction : IMyCartSetLineItemCustomFieldAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public MyCartSetLineItemCustomFieldAction()
        {
            this.Action = "setLineItemCustomField";
        }
    }
}
