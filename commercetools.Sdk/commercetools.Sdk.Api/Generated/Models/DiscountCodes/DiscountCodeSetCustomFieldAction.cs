using System;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    public partial class DiscountCodeSetCustomFieldAction : IDiscountCodeSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public DiscountCodeSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
