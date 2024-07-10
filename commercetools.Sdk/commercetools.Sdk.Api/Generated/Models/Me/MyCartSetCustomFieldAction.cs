using System;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCartSetCustomFieldAction : IMyCartSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public MyCartSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
