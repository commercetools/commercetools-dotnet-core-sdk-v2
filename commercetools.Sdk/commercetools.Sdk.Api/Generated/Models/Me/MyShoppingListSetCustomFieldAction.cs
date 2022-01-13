using System;


namespace commercetools.Api.Models.Me
{
    public partial class MyShoppingListSetCustomFieldAction : IMyShoppingListSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public MyShoppingListSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
